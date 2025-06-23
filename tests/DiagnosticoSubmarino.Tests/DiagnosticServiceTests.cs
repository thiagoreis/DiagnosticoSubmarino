using DiagnosticoSubmarino.Domain.Services;

namespace DiagnosticoSubmarino.Tests;

public class DiagnosticServiceTests
{
    [Fact]
    public void Should_CalculatePowerConsumption_Correctly()
    {
        var report = new List<string>
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };

        var service = new DiagnosticService();
        var result = service.CalculatePowerConsumption(report);

        Assert.Equal(198, result);
    }
}
