using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace eWasteManagement.Pages;

public class Index_Tests : eWasteManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
