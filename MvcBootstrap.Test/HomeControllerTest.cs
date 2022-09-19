using Microsoft.Extensions.Logging;
using Moq;
using MvcBootstrap.Controllers;

namespace MvcBootstrap.Test
{
    public class HomeControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void It_works()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mockLogger.Object);

            var result = controller.Index();

            Assert.That(result, Is.Not.Null);
        }
    }
}