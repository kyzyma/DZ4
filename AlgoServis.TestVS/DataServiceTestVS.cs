using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;


namespace AlgoServis.TestVS
{
    [TestClass]
    public class DataServiceTestVS
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetElementAt_When_given_index_out_count_element_returns_exception()
        {
            DataService ds = new DataService(2);
            ds.AddItem(1);
            ds.AddItem(2);

            //Act
            ds.GetElementAt(6);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RemoveAt_When_given_index_out_count_element_returns_exception()
        {
            DataService ds = new DataService(2);
            ds.AddItem(1);
            ds.AddItem(2);

            //Act
            ds.RemoveAt(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ctr_When_given_capacity_negativ_or_big_values_returns_exception()
        {            
            //Act
            new DataService(-2); ;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetMax_When_given_empty_list_returns_exception()
        {
            DataService ds = new DataService(2);
            
            //Act
            ds.GetMax();
        }
    }
}
