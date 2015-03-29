namespace MyLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Shouldly;

    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void ShouldReverseString()
        {
            // Arrange
            MyClass myClass = new MyClass();

            // Act
            string result = myClass.ReverseString("abc");

            // Assert
            result.ShouldBe("cba");
        }
    }
}
