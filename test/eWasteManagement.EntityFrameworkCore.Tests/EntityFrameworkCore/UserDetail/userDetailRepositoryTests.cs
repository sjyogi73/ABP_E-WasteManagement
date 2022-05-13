using System;
using System.Threading.Tasks;
using eWasteManagement.UserDetail;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace eWasteManagement.EntityFrameworkCore.UserDetail
{
    public class userDetailRepositoryTests : eWasteManagementEntityFrameworkCoreTestBase
    {
        private readonly IuserDetailRepository _userDetailRepository;

        public userDetailRepositoryTests()
        {
            _userDetailRepository = GetRequiredService<IuserDetailRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
