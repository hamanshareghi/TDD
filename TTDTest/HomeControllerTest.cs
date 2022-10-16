using Microsoft.AspNetCore.Mvc;
using TDD.Controllers;

namespace TTDTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            //arrange
            HomeController controller = new HomeController();
            //act
            var result = controller.Index();
            //assert
            Assert.IsType<ViewResult>(result);


        }
    }
}