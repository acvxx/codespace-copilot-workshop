namespace WebApiTests;
// add a namespace for WeatherForecastController
using WebApi.Controllers;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForecastController
    [TestMethod]
    public void TestGetRange()
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange { Length = 5 });

        // assert
        Assert.AreEqual(5, result.Count());
    }


}