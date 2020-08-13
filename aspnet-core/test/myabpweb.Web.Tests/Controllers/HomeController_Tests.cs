using System.Threading.Tasks;
using myabpweb.Models.TokenAuth;
using myabpweb.Web.Controllers;
using Shouldly;
using Xunit;

namespace myabpweb.Web.Tests.Controllers
{
    public class HomeController_Tests: myabpwebWebTestBase
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