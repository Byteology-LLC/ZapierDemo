using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ZapierDemo.Pages;

[Collection(ZapierDemoTestConsts.CollectionDefinitionName)]
public class Index_Tests : ZapierDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
