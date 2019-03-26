using System.Threading.Tasks;
using KancelarijaBoilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace KancelarijaBoilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: KancelarijaBoilerplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
