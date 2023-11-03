using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace UnitTestProject1
{
    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int firstNo = 8; int secondNo = 4;

            //Act 

            bool result = firstNo > secondNo;

            Assert.IsTrue(result);

            firstNo.Should().BeGreaterThan(secondNo);


        }
    }
}
