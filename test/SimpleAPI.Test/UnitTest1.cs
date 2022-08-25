namespace SimpleAPI.Test;
using SimpleAPI.Controllers;


public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsListOfWeatherdata()
    {
        var returnWeather = controller.Get();
        Assert.Equal(5, returnWeather.Count());

    } 
    [Fact]
    public void Test1()
    {

    }
}