using Logic;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    public class AlgoServiceTect
    {
        [TestFixture]
        class AlgoServicTest
        {
            [Test]
            public void DoubleSum_When_given_int_list_Then_returns_double_sum_list()
            {
                //Arrange
                AlgoService serv = new AlgoService();
                List<int> list = new List<int> { 1, 2, 3, 4, 5 };

                //Act
                int sum = serv.DoubleSum(list);

                //Assert
                NUnit.Framework.Assert.That(sum, Is.EqualTo(30));
            }

            [Test]
            public void MinValue_When_given_int_list_Then_returns_min_value()
            {
                //Arrange
                AlgoService serv = new AlgoService();
                List<int> list = new List<int> { 1, 2, 3, 4, 5 };

                //Act
                int min = serv.MinValue(list);

                //Assert
                NUnit.Framework.Assert.That(min, Is.EqualTo(1));
            }

            [Test]
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
                NUnit.Framework.Assert.That(val, Is.EqualTo(0.86));
            }

            [Test]
            public void MinValue_When_given_int_list_Then_returns_average_value()
            {
                //Arrange
                AlgoService serv = new AlgoService();
                List<int> list = new List<int> { 1, 2, 2, 0, 5 };

                //Act
                double aver = serv.GetAverage(list);

                //Assert
                NUnit.Framework.Assert.That(aver, Is.EqualTo(2));
            }

            [Test]
            public void Sqr_When_given_koeficient_list_Then_returns_result_function()
            {
                //Arrange
                AlgoService serv = new AlgoService();
                int data = 3;
                
                //Act
                double val = serv.Sqr(data);

                //Assert
                NUnit.Framework.Assert.That(val, Is.EqualTo(9));
            }
        }
    }
}
