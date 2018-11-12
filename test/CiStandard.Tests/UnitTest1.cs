using System;

using Moq;

using Xunit;

namespace CiStandard.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new Mock<Class1>();
            c.Setup(class1 => class1.IsTrue).Returns(false);
            Assert.False(c.Object.IsTrue);
        }
    }
}
