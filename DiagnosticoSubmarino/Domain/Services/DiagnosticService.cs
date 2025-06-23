using DiagnosticoSubmarino.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoSubmarino.Domain.Services
{
    public class DiagnosticService
    {
        public int CalculatePowerConsumption(IEnumerable<string> report)
        {
            var gammaBinary = new GammaRateStrategy().Calculate(report);
            var epsilonBinary = new EpsilonRateStrategy().Calculate(report);

            var gammaDecimal = Convert.ToInt32(gammaBinary, 2);
            var epsilonDecimal = Convert.ToInt32(epsilonBinary, 2);

            return gammaDecimal * epsilonDecimal;
        }
    }

}
