using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    [TestFixture]
    public class MasterServiceTest
    {
        [Test]
        [TestCase(typeof(AlgoService),null)]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ctr_When_date_is_null_Then_return_throw_exception(IAlgoService a, IDataService d)
        {
            //Act
            new MasterService(a, d);
         }
    }
}
