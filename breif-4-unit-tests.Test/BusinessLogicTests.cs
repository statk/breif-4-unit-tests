using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace breif_4_unit_tests.Test
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void CalculateSum_should_return_sum_of_two_numbers()
        {
            // Arrange.
            var firstNumber = 2;
            var secondNumber = 2;
            var businessLogic = new BusinessLogic(firstNumber, secondNumber);

            // Act.
            var sumResult = businessLogic.CalculateSum();

            // Assert.
            var expectedSumResult = firstNumber + secondNumber;
            Assert.AreEqual(expectedSumResult, sumResult);
        }


        [TestMethod]
        public void CalculateMultiplication_should_return_multiplication_of_two_numbers()
        {
            // Arrange.
            var firstNumber = 2;
            var secondNumber = 2;
            var businessLogic = new BusinessLogic(firstNumber, secondNumber);

            // Act.
            var sumResult = businessLogic.CalculateMultiplication();

            // Assert.
            var expectedSumResult = firstNumber * secondNumber;
            Assert.AreEqual(expectedSumResult, sumResult);
        }
    }
}
