using Moq;
using Sysmanager.Application.Data.Mysql.Entities;
using Sysmanager.Application.Data.Mysql.Repositories;

namespace SysManager.Tests.Mocks
{
    public static class UnityRepositoryMocks
    {
        public static void MockGetByNameAsync(this Mock<UnityRepository> mockRepository, UnityEntity response)
        {
            mockRepository.Setup(repository => repository.GetByNameAsync(It.IsAny<string>())).ReturnsAsync(response);
        }
    }
}