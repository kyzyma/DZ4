using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace AlgoServis.TestVS
{
    [TestClass]
    public class MasterServiceTestVS
    {

        [TestMethod]
        //[TestCase(typeof(AlgoService), null)]
        
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ctr_When_date_is_null_Then_return_throw_exception()
        {
            AlgoService a = new AlgoService();
            DataService d = null;

            //Act
            new MasterService(a, d);
        }
    }
}
