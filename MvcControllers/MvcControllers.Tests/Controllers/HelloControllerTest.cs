using Castle.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcControllers.Controllers;
using System.Web.Routing;

namespace MvcControllers.Tests.Controllers
{
    [TestClass]
    public class When_HelloController_Executes
    {
        [TestMethod]
        public void Write_To_The_Log()
        {
            // Arrange
            string logResult = null;
            var loggerMock = new Mock<MvcControllers.Infrastructure.ILogger>();
            loggerMock.Setup(l => l.Log(It.IsAny<string>())).Callback((string message) =>
            {
                logResult = message;
            });
            var controller = new HelloController(loggerMock.Object);
            var requestContextMock = new Mock<RequestContext>();

            // Act
            controller.Execute(requestContextMock.Object);

            // Assert
            Assert.IsNotNull(logResult);
            Assert.IsTrue(logResult.Length > 0);
        }
    }
}
