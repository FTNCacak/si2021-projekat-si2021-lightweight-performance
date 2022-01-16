using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class MembershipBusinessTests
    {
        private readonly Mock<IMembershipRepository> mockMembershipRepository = new Mock<IMembershipRepository>();
        private MembershipBusiness membershipBusiness;
        private readonly List<Membership> memberships = new List<Membership>();
        private readonly Membership membership = new Membership
        {
            MembershipID = 1,
            FirstName = "Dalibor",
            LastName = "Tosic",
            Address = "adresa",
            PhoneNumber = "1234567890",
            BirthDate = Convert.ToDateTime("1/1/2000 00:00:00"),
            PaymentDate = DateTime.Now,
            ExpirationDate = DateTime.Now.AddMonths(1),
            Note = "test"
        };

        [TestInitialize]
        public void Initialize()
        {
            memberships.Add(membership);
            memberships.Add(new Membership
            {
                MembershipID = 2,
                FirstName = "Aleksa",
                LastName = "Matovic",
                Address = "adresa",
                PhoneNumber = "1234567890",
                BirthDate = Convert.ToDateTime("1/1/2000 00:00:00"),
                PaymentDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(1),
                Note = "test"
            });
        }

        [TestMethod]
        public void SearchMembership_MatchExists()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.GetAllMemberships()).Returns(memberships);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.SearchMembership("Dalibor", "Tosic");

            // Assert

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void GetMembershipByID_ReturnsMatch()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.GetAllMemberships()).Returns(memberships);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.GetMembershipByID(1);

            // Assert

            Assert.AreEqual(membership, result);
        }

        [TestMethod]
        public void GetAllMemberships_ReturnsNotNull()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.GetAllMemberships()).Returns(memberships);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.GetAllMemberships();

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InsertMembership_IsInserted()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.InsertMembership(membership)).Returns(1);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.InsertMembership(membership);

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateMembership_IsUpdated()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.UpdateMembership(membership, 1)).Returns(1);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.UpdateMembership(membership, 1);

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateMembershipDetails_IsUpdated()
        {
            // Arrange

            mockMembershipRepository.Setup(x => x.UpdateMembershipDetails(membership)).Returns(1);
            membershipBusiness = new MembershipBusiness(mockMembershipRepository.Object);

            // Act

            var result = membershipBusiness.UpdateMembershipDetails(membership);

            // Assert

            Assert.IsTrue(result);
        }
    }
}
