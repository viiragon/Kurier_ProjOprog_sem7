using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Kurier.Models;

namespace KurierTest.Models
{
    [TestClass]
    public class IModelTest
    {
        [TestMethod]
        public void sumNumbersTest()
        {
            IModel model = new Model();
            Assert.AreEqual(0, model.sumNumbers(null));
            Assert.AreEqual(0, model.sumNumbers(new int[] { 0 }));
            Assert.AreEqual(3, model.sumNumbers(new int[] {0, 1, 2}));
            Assert.AreEqual(2, model.sumNumbers(new int[] { -100000, 100000, 2 }));
            Assert.AreEqual(8, model.sumNumbers(new int[] { 0, -1, 2, -3, 4, -5, 6, -7, 8, -9, 10, -11, 12, -13, 14, -15, 16 }));
        }
    }
}
