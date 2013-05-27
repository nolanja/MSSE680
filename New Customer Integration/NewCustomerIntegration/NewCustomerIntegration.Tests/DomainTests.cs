using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewCustomerIntegration.Domain.Models;
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
            using (var db = new DBIntegrationContext())
            {

                var newOrg = new Organization();

                newOrg.OrganizationCode = "RWF";
                newOrg.OrganizationName = "RealWorld Diners";
                newOrg.PhoneNumber = "208-555-1234";
                newOrg.FaxNumber = "208-555-3421";
                newOrg.ParentOrganizationCode = "4321";
                newOrg.Theme = "Standard";
                newOrg.Skin = "Red";
                newOrg.Active = true;
                newOrg.DELETED = false;
                newOrg.CreatedDateTime = new DateTime();
                newOrg.CreatedBy = "Administrator";
                newOrg.ModifiedDateTime = new DateTime();
                newOrg.ModifiedBy = "Administrator";
                db.Organizations.Add(newOrg);


                //Act
                db.SaveChanges();


                //Assert -- See if the record retrieved matches the one just entered
                var savedOrg = (from d in db.Organizations where d.OrganizationId == newOrg.OrganizationId select d).Single();

                Assert.AreEqual(savedOrg.OrganizationName, newOrg.OrganizationName);
                Assert.AreEqual(savedOrg.OrganizationCode, newOrg.OrganizationCode);
                Assert.AreEqual(savedOrg.PhoneNumber, newOrg.PhoneNumber);
                Assert.AreEqual(savedOrg.FaxNumber, newOrg.FaxNumber);
                Assert.AreEqual(savedOrg.ParentOrganizationCode, newOrg.ParentOrganizationCode);
                Assert.AreEqual(savedOrg.Theme, newOrg.Theme);
                Assert.AreEqual(savedOrg.Skin, newOrg.Skin);
                Assert.AreEqual(savedOrg.Active, newOrg.Active);
                Assert.AreEqual(savedOrg.DELETED, newOrg.DELETED);
                Assert.AreEqual(savedOrg.CreatedDateTime, newOrg.CreatedDateTime);
                Assert.AreEqual(savedOrg.CreatedBy, newOrg.CreatedBy);
                Assert.AreEqual(savedOrg.ModifiedDateTime, newOrg.ModifiedDateTime);
                Assert.AreEqual(savedOrg.ModifiedBy, newOrg.ModifiedBy);


                //cleanup
                db.Organizations.Remove(newOrg);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void SaveNewAddress()
        {

            //Arrange

            using (var db = new DBIntegrationContext())
            {

                var newAdd = new Address();

                newAdd.SiteId = 101;
                newAdd.AddressTypeId = 5;
                newAdd.AddressLine1 = "RealWorld Food";
                newAdd.AddressLine2 = "101 Maple Str";
                newAdd.AddressLine3 = "Suite 150";
                newAdd.City = "Meridian";
                newAdd.StateProvinceRegionId = 43;
                newAdd.PostalCode = "83646";
                newAdd.CountryRegionId = 01;
                newAdd.CreatedDateTime = new DateTime();
                newAdd.CreatedBy = "Administrator";
                newAdd.ModifiedDateTime = new DateTime();
                newAdd.ModifiedBy = "Administrator";
                db.Addresses.Add(newAdd);

                //Act
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                Address savedAdd = (from d in db.Addresses where d.AddressId == newAdd.AddressId select d).Single();

                Assert.AreEqual(savedAdd.SiteId, newAdd.SiteId);
                Assert.AreEqual(savedAdd.AddressTypeId, newAdd.AddressTypeId);
                Assert.AreEqual(savedAdd.AddressLine1, newAdd.AddressLine1);
                Assert.AreEqual(savedAdd.AddressLine2, newAdd.AddressLine2);
                Assert.AreEqual(savedAdd.AddressLine3, newAdd.AddressLine3);
                Assert.AreEqual(savedAdd.City, newAdd.City);
                Assert.AreEqual(savedAdd.StateProvinceRegionId, newAdd.StateProvinceRegionId);
                Assert.AreEqual(savedAdd.PostalCode, newAdd.PostalCode);
                Assert.AreEqual(savedAdd.CountryRegionId, newAdd.CountryRegionId);
                Assert.AreEqual(savedAdd.CreatedDateTime, newAdd.CreatedDateTime);
                Assert.AreEqual(savedAdd.CreatedBy, newAdd.CreatedBy);
                Assert.AreEqual(savedAdd.ModifiedDateTime, newAdd.ModifiedDateTime);
                Assert.AreEqual(savedAdd.ModifiedBy, newAdd.ModifiedBy);


                //cleanup
                db.Addresses.Remove(newAdd);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void SaveNewSiteInfo()
        {

            //Arrange
            using (var db = new DBIntegrationContext())
            {
                var newSite = new Site();

                newSite.OrganizationId = 1234;
                newSite.SiteTypeId = 7;
                newSite.SiteName = "Little Island";
                newSite.SiteCode = "RWF001";
                newSite.TimeZoneId = 8;
                newSite.CreatedDateTime = new DateTime();
                newSite.CreatedBy = "Adminstrator";
                newSite.ModifiedDateTime = new DateTime();
                newSite.ModifiedBy = "Administrator";
                db.Sites.Add(newSite);

                //Act
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                Site saveSite = (from d in db.Sites where d.SiteId == newSite.SiteId select d).Single();

                Assert.AreEqual(saveSite.OrganizationId, newSite.OrganizationId);
                Assert.AreEqual(saveSite.SiteTypeId, newSite.SiteTypeId);
                Assert.AreEqual(saveSite.SiteName, newSite.SiteName);
                Assert.AreEqual(saveSite.SiteCode, newSite.SiteCode);
                Assert.AreEqual(saveSite.TimeZoneId, newSite.TimeZoneId);
                Assert.AreEqual(saveSite.CreatedDateTime, newSite.CreatedDateTime);
                Assert.AreEqual(saveSite.CreatedBy, newSite.CreatedBy);
                Assert.AreEqual(saveSite.ModifiedDateTime, newSite.ModifiedDateTime);
                Assert.AreEqual(saveSite.ModifiedBy, newSite.ModifiedBy);

                //cleanup
                db.Sites.Remove(newSite);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void SaveNewPerson()
        {

            //Arrange
            using (var db = new DBIntegrationContext())
            {
            
                var newUser = new Person();

                newUser.OrganizationId = 1234;
                newUser.UserTypeId = 12;
                newUser.FirstName = "Fred";
                newUser.LastName = "Jones";
                newUser.PhoneNumber = "208-555=-234";
                newUser.EmailAddress = "fjones@itradenetwork.com";
                newUser.UnitName = "RealIdaho";
                newUser.UnitNumber = "4301";
                newUser.Department = "Fast Food";
                newUser.CreatedDateTime = new DateTime();
                newUser.CreatedBy = "Administrator";
                newUser.ModifiedDateTime = new DateTime();
                newUser.ModifiedBy = "Administrator";
                db.People.Add(newUser);

                //Act
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                var saveUser = (from d in db.People where d.UserId == newUser.UserId select d).Single();

                Assert.AreEqual(saveUser.OrganizationId, newUser.OrganizationId);
                Assert.AreEqual(saveUser.UserTypeId, newUser.UserTypeId);
                Assert.AreEqual(saveUser.FirstName, newUser.FirstName);
                Assert.AreEqual(saveUser.LastName, newUser.LastName);
                Assert.AreEqual(saveUser.PhoneNumber, newUser.PhoneNumber);
                Assert.AreEqual(saveUser.EmailAddress, newUser.EmailAddress);
                Assert.AreEqual(saveUser.UnitName, newUser.UnitName);
                Assert.AreEqual(saveUser.UnitNumber, newUser.UnitNumber);
                Assert.AreEqual(saveUser.Department, newUser.Department);
                Assert.AreEqual(saveUser.CreatedDateTime, newUser.CreatedDateTime);
                Assert.AreEqual(saveUser.ModifiedDateTime, newUser.ModifiedDateTime);
                Assert.AreEqual(saveUser.ModifiedBy, newUser.ModifiedBy);

                //cleanup
                db.People.Remove(newUser);
                db.SaveChanges();            
            }

        }

        [TestMethod]
        public void CheckSiteType()
        {
            //Arrange
            using (var db = new DBIntegrationContext())
            {
                var newSiteType = new SiteType();

                newSiteType.SiteTypeName = "Restaurant";
                newSiteType.CreatedDateTime = new DateTime();
                newSiteType.CreatedBy = "Administrator";
                newSiteType.ModifiedDateTime = new DateTime();
                newSiteType.ModifiedBy = "Administrator";
                db.SiteTypes.Add(newSiteType);

                //Act
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                var saveSite = (from d in db.SiteTypes where d.SiteTypeId == newSiteType.SiteTypeId select d).Single();

                Assert.AreEqual(saveSite.SiteTypeName, newSiteType.SiteTypeName);
                Assert.AreEqual(saveSite.CreatedDateTime, newSiteType.CreatedDateTime);
                Assert.AreEqual(saveSite.CreatedBy, newSiteType.CreatedBy);
                Assert.AreEqual(saveSite.ModifiedDateTime, newSiteType.ModifiedDateTime);
                Assert.AreEqual(saveSite.ModifiedBy, newSiteType.ModifiedBy);

                //Cleanup
                db.SiteTypes.Remove(newSiteType);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void CheckUserType()
        { 
            //Arrange
            using (var db = new DBIntegrationContext())
            {
                var newUserType = new UserType();

                newUserType.UserTypeName = "User Name";
                newUserType.CreatedDateTime = new DateTime();
                newUserType.CreatedBy = "Administrator";
                newUserType.ModifiedDateTime = new DateTime();
                newUserType.ModifiedBy = "Administrator";
                db.UserTypes.Add(newUserType);

                //Act
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                var saveUserType = (from d in db.UserTypes where d.UserTypeId == newUserType.UserTypeId select d).Single();

                Assert.AreEqual(saveUserType.UserTypeName, newUserType.UserTypeName);
                Assert.AreEqual(saveUserType.CreatedDateTime, newUserType.CreatedDateTime);
                Assert.AreEqual(saveUserType.CreatedBy, newUserType.CreatedBy);
                Assert.AreEqual(saveUserType.ModifiedDateTime, newUserType.ModifiedDateTime);
                Assert.AreEqual(saveUserType.ModifiedBy, newUserType.ModifiedBy);

                //Cleanup
                db.UserTypes.Remove(newUserType);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void CheckRules()
        {
            //Arrange
            using (var db = new DBIntegrationContext())
            {
                var newRule = new NewCustomerIntegration.Domain.Models.Rule();

                newRule.ValueTypeId = 16;
                newRule.RuleName = "Substitution";
                newRule.RuleDescription = "Substitute out of stock item with closest like item";
                newRule.CreatedDateTime = new DateTime();
                newRule.CreatedBy = "Administrator";
                newRule.ModifiedDateTime = new DateTime();
                newRule.ModifiedBy = "Administrator";
                db.Rules.Add(newRule);

                //Act 
                db.SaveChanges();

                //Assert -- See if the record retrieved matches the one just entered
                var saveRules = (from d in db.Rules where d.RuleId == newRule.RuleId select d).Single();

                Assert.AreEqual(saveRules.ValueTypeId, newRule.ValueTypeId);
                Assert.AreEqual(saveRules.RuleName, newRule.RuleName );
                Assert.AreEqual(saveRules.RuleDescription, newRule.RuleDescription);
                Assert.AreEqual(saveRules.CreatedDateTime, newRule.CreatedDateTime);
                Assert.AreEqual(saveRules.CreatedBy, newRule.CreatedBy);
                Assert.AreEqual(saveRules.ModifiedDateTime, newRule.ModifiedDateTime);
                Assert.AreEqual(saveRules.ModifiedBy, newRule.ModifiedBy);

                //Cleanup
                db.Rules.Remove(newRule);
                db.SaveChanges();
            }
        }

    }
}
