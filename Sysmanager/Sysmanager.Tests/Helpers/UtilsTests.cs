using Sysmanager.Application.Contracts.Unity.Request;
using Sysmanager.Application.Helpers;
using System;
using Xunit;

namespace Sysmanager.Tests.Helpers
{
    public class UtilsTests
    {
        [Fact]
        public void ToJsonSuccecess()
        {
            //Arrange 
            var request = new UnityPostRequest() {
                Active = true,
                Name = "Test"
            };

            var expectedResponse = "{\"Name\":\"Test\",\"Active\":\"true\"}";

            //Act
            var response = Utils.ToJson(request);

            //Assert
            Assert.Equal(expectedResponse, response);
        }
    }
}
