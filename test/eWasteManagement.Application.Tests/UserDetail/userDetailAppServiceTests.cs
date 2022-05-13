using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace eWasteManagement.UserDetail
{
    public class userDetailAppServiceTests : eWasteManagementApplicationTestBase
    {
        private readonly IuserDetailAppService _userDetailAppService;

        public userDetailAppServiceTests()
        {
            _userDetailAppService = GetRequiredService<IuserDetailAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
