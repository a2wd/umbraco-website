using NUnit.Framework;
using System;

namespace a2wd.Umbraco.Tests
{
    [TestFixture]
    public class HelperTests
    {
        #region properties
        private int exampleInt;
        #endregion

        #region methods
        [SetUp]
        protected void SetUp()
        {
            exampleInt = 1;
        }

        [Test]
        public void ExampleTest()
        {
            //Arrange

            //Act
            exampleInt++;

            //Assert
            Assert.That(exampleInt, Is.EqualTo(2));
        }
        #endregion
    }
}
