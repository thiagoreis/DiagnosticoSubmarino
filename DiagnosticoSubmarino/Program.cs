using DiagnosticoSubmarino.Domain.Services;

class Program
{
    static void Main()
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
        var powerConsumption = service.CalculatePowerConsumption(report);

        Console.WriteLine($"Consumo de energia: {powerConsumption}");
    }
}
