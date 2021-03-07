using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Fundamentals.Math();

            var result = math.Add(1, 2);

            Assert.AreEqual(3 , result);
        }


    }
}
