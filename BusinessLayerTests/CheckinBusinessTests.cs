using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace BusinessLayerTests
{
    [TestClass]
    public class CheckinBusinessTests
    {
        private readonly Mock<ICheckinRepository> mockCheckinRepository = new Mock<ICheckinRepository>();
        private CheckinBusiness checkinBusiness;
        private readonly Checkin checkin = new Checkin
        {
            CheckinDate = DateTime.Now,
            MembershipID = 1
        };

        [TestMethod]
        public void InsertCheckin_IsInserted()
        {
            // Arrange

            mockCheckinRepository.Setup(x => x.InsertCheckin(checkin)).Returns(1);
            checkinBusiness = new CheckinBusiness(mockCheckinRepository.Object);

            // Act

            var result = checkinBusiness.InsertCheckin(checkin);

            // Assert

            Assert.IsTrue(result);
        }
    }
}
