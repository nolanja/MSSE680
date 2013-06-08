using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using NewCustomerIntegration.App_Start;
using NewCustomerIntegration.Services;
using NewCustomerIntegration.Controllers;
using NewCustomerIntegration.Factories;

namespace NewCustomerIntegration
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var container = new UnityContainer();
            container.RegisterType<INewCustomerOrganizationService, OrganizationService>();
            container.RegisterType<IController, OrganizationController>("Organization");
            container.RegisterType<INewCustomerAddressService, AddressService>();
            container.RegisterType<IController, AddressController>("Address");
            var factory = new UnityControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(factory);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}