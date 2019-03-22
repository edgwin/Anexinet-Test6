using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test6.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetExpected()
        {
            //Arrange
            var expected = "niwgdE";
            var input = "Edgwin";
            //Act
            var response = Program.proccess(input);
            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void GetUnExpected()
        {
            //Arrange
            var expected = "ABC";
            var input = "Edgwin";
            //Act
            var response = Program.proccess(input);
            //Assert
            Assert.AreNotEqual(response, expected);
        }

        [TestMethod]
        public void InvalidInput()
        {
            //Arrange
            var expected = "Invalid input";
            var input = "";
            //Act
            var response = Program.proccess(input);
            //Assert
            Assert.AreEqual(response, expected);
        }
    }
}
