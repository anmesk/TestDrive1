using System;
using Xunit;
using TestDrive1.Controllers;

namespace TestDrive1.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello World!", result);
        }
    }
}
