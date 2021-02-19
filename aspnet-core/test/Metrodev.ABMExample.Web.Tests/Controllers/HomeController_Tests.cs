using System.Threading.Tasks;
using Metrodev.ABMExample.Models.TokenAuth;
using Metrodev.ABMExample.Web.Controllers;
using Shouldly;
using Xunit;

namespace Metrodev.ABMExample.Web.Tests.Controllers
{
    public class HomeController_Tests: ABMExampleWebTestBase
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