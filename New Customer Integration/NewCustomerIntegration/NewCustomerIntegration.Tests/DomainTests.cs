using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewCustomerIntegration.Models.Domain;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace NewCustomerIntegration.DomainTests
{
    [TestClass]
    public class DomainUnitTests
    {
        [TestMethod]
        public void SaveNewOrganization()
        {

            //Arrange
            CustomerDataEntities db = new CustomerDataEntities();
                 
            Organization newOrg = new Organization();
           
            newOrg.OrganizationCode = "RWF";
            newOrg.OrganizationName = "RealWorld Diners";
            newOrg.ParentOrganization = "RealWorld Food";
            newOrg.AddressID = 001;
            newOrg.PhoneNumber = "208-555-1234";
            newOrg.FaxNumber = "208-555-3421";
            db.Organizations.AddObject(newOrg);

            //Act
            db.SaveChanges();

            //Assert -- See if the record retrieved matches the one just entered
            Organization savedOrg = (from d in db.Organizations where d.OrganizationId == newOrg.OrganizationId select d).Single();

            Assert.AreEqual(savedOrg.OrganizationName, newOrg.OrganizationName);
            Assert.AreEqual(savedOrg.OrganizationCode, newOrg.OrganizationCode);
            Assert.AreEqual(savedOrg.ParentOrganization, newOrg.ParentOrganization);
            Assert.AreEqual(savedOrg.PhoneNumber, newOrg.PhoneNumber);
            Assert.AreEqual(savedOrg.FaxNumber, newOrg.FaxNumber);
            Assert.AreEqual(savedOrg.AddressID, newOrg.AddressID);

            //cleanup
            db.Organizations.DeleteObject(newOrg);

        }

        [TestMethod]
        public void SaveNewAddress()
        {

            //Arrange
            CustomerDataEntities db = new CustomerDataEntities();

            Address newAdd = new Address();
            
            newAdd.SiteId = 101;
            newAdd.AddressType = 5;
            newAdd.AddressLine1  = "RealWorld Food";
            newAdd.AddressLine2  = "101 Maple Str";
            newAdd.AddressLine3 = "Suite 150";
            newAdd.City  = "Meridian";
            newAdd.StateProvince = "ID";
            newAdd.PostalCode = 83646;
            newAdd.CountryRegion = "USA";
            db.Addresses.AddObject(newAdd);

            //Act
            db.SaveChanges();

            //Assert -- See if the record retrieved matches the one just entered
            Address savedAdd = (from d in db.Addresses  where d.AddressId == newAdd.AddressId select d).Single();

            Assert.AreEqual(savedAdd.SiteId , newAdd.SiteId);
            Assert.AreEqual(savedAdd.AddressLine1, newAdd.AddressLine1);
            Assert.AreEqual(savedAdd.AddressLine2, newAdd.AddressLine2);
            Assert.AreEqual(savedAdd.AddressLine3, newAdd.AddressLine3);
            Assert.AreEqual(savedAdd.AddressType, newAdd.AddressType);
            Assert.AreEqual(savedAdd.City, newAdd.City);
            Assert.AreEqual(savedAdd.CountryRegion, newAdd.CountryRegion);
            Assert.AreEqual(savedAdd.StateProvince, newAdd.StateProvince);
            Assert.AreEqual(savedAdd.PostalCode, newAdd.PostalCode);

            //cleanup
            db.Addresses.DeleteObject(newAdd);

        }

        [TestMethod]
        public void SaveNewSiteInfo()
        {

            //Arrange
            CustomerDataEntities db = new CustomerDataEntities();
            Site newSite = new Site();

            newSite.OrganizationId = 1;
            newSite.SiteTypeId = 7;
            newSite.SiteName = "Little Island";
            newSite.SiteCode = "RWF001";
            newSite.TimeZoneId = 8;
            newSite.AddressId = 4;
            db.Sites.AddObject(newSite);

            //Act
            db.SaveChanges();

            //Assert -- See if the record retrieved matches the one just entered
            Site saveSite = (from d in db.Sites where d.SiteId == newSite.SiteId select d).Single();

            Assert.AreEqual(saveSite.OrganizationId, newSite.OrganizationId);
            Assert.AreEqual(saveSite.SiteTypeId, newSite.SiteTypeId);
            Assert.AreEqual(saveSite.SiteName, newSite.SiteName);
            Assert.AreEqual(saveSite.SiteCode, newSite.SiteCode);
            Assert.AreEqual(saveSite.TimeZoneId, newSite.TimeZoneId);
            Assert.AreEqual(saveSite.AddressId, newSite.AddressId);

            //cleanup
            db.Sites.DeleteObject(newSite);
        }

        [TestMethod]
        public void SaveNewBusinessRules()
        {

            //Arrange
            CustomerDataEntities db = new CustomerDataEntities();
            BusinessRule  newRule = new BusinessRule();

            newRule.RuleName = "Quick Order";
            newRule.RuleDescription = "Override order wait times";
            newRule.RuleValue= "High";

            db.BusinessRules.AddObject(newRule);

            //Act
            db.SaveChanges();

            //Assert -- See if the record retrieved matches the one just entered
            BusinessRule saveRule = (from d in db.BusinessRules where d.RuleId == newRule.RuleId select d).Single();

            Assert.AreEqual(saveRule.RuleName, newRule.RuleName);
            Assert.AreEqual(saveRule.RuleDescription, newRule.RuleDescription);
            Assert.AreEqual(saveRule.RuleValue, newRule.RuleValue);


            //cleanup
            db.BusinessRules.DeleteObject(newRule);
        }

    }
}
