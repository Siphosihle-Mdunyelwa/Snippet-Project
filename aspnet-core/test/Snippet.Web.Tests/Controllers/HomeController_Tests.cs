using System.Threading.Tasks;
using Snippet.Models.TokenAuth;
using Snippet.Web.Controllers;
using Shouldly;
using Xunit;

namespace Snippet.Web.Tests.Controllers
{
    public class HomeController_Tests: SnippetWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}