﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //[TestClass]
    //public class MathTests
    //{
    //    [TestMethod]
    //    public void Add_WhenCalled_ReturnTheSumOfArguments()
    //    {
    //        var math = new Fundamentals.Math();

    //        var result = math.Add(1, 2);

    //        Assert.AreEqual(3 , result);
    //    }

    //    [TestMethod]
    //    public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
    //    {
    //        var math = new Fundamentals.Math();

    //        var result = math.Max(2, 1);

    //        Assert.AreEqual(2, result);
    //    }

    //    [TestMethod]
    //    public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
    //    {
    //        var math = new Fundamentals.Math();

    //        var result = math.Max(1, 2);

    //        Assert.AreEqual(2, result);
    //    }
        
    //    [TestMethod]
    //    public void Max_ArgumentAreEqual_ReturnSameArgument()
    //    {
    //        var math = new Fundamentals.Math();

    //        var result = math.Max(1, 1);

    //        Assert.AreEqual(1, result);
    //    }
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(2,2,2)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            NUnit.Framework.Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
