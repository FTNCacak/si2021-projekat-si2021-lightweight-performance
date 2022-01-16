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
    public class TrainingBusinessTests
    {
        private readonly Mock<ITrainingRepository> mockTrainingRepository = new Mock<ITrainingRepository>();
        private TrainingBusiness trainingBusiness;
        private readonly List<Training> trainings = new List<Training>();
        private readonly Training training = new Training
        {
            Appointment = DateTime.Now,
            MembershipID = 1,
            EmployeeID = 1,
            Type = "test"
        };

        [TestMethod]
        public void GetAllTrainings_ReturnsNotNull()
        {
            // Arrange

            mockTrainingRepository.Setup(x => x.GetAllTrainings()).Returns(trainings);
            trainingBusiness = new TrainingBusiness(mockTrainingRepository.Object);

            // Act

            var result = trainingBusiness.GetAllTrainings();

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InsertTraining_IsInserted()
        {
            // Arrange

            mockTrainingRepository.Setup(x => x.InsertTraining(training)).Returns(1);
            trainingBusiness = new TrainingBusiness(mockTrainingRepository.Object);

            // Act

            var result = trainingBusiness.InsertTraining(training);

            // Assert

            Assert.IsTrue(result);
        }
    }
}
