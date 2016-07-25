using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;

namespace AlgoServis.TestVS
{
    [TestClass]
    public class AlgoServiceTestVS
    {
        [TestMethod]
        public void DoubleSum_When_given_int_list_Then_returns_double_sum_list()
        {
            //Arrange
            AlgoService serv = new AlgoService();
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            //Act
            int sum = serv.DoubleSum(list);

            //Assert            
            Assert.AreEqual(sum, 30);

        }

        [TestMethod]
        public void MinValue_When_given_int_list_Then_returns_min_value()
        {
            //Arrange
            AlgoService serv = new AlgoService();
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            //Act
            int min = serv.MinValue(list);

            //Assert     
            Assert.AreEqual(min, 1);

        }

        [TestMethod]
        public void Function_When_given_koeficient_list_Then_returns_result_function()
        {
            //Arrange
            AlgoService serv = new AlgoService();
            int a = 3;
            double b = 1;
            int c = 1;
            double d = 1;

            //Act
            double val = Math.Round(serv.Function(a, b, c, d), 2);

            //Assert        
            Assert.AreEqual(val, 0.86);

        }

        [TestMethod]
        public void MinValue_When_given_int_list_Then_returns_average_value()
        {
            //Arrange
            AlgoService serv = new AlgoService();
            List<int> list = new List<int> { 1, 2, 2, 0, 5 };

            //Act
            double aver = serv.GetAverage(list);

            //Assert
            Assert.AreEqual(aver, 2);
        }

        [TestMethod]
        public void Sqr_When_given_koeficient_list_Then_returns_result_function()
        {
            //Arrange
            AlgoService serv = new AlgoService();
            int data = 3;

            //Act
            double val = serv.Sqr(data);

            //Assert            
            Assert.AreEqual(val, 9);

        }
    }
}

