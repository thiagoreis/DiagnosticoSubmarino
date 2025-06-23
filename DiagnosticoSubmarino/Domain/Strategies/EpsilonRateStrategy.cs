using DiagnosticoSubmarino.Domain.Interfaces;
using DiagnosticoSubmarino.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoSubmarino.Domain.Strategies
{
    public class EpsilonRateStrategy : IBitCriteriaStrategy
    {
        public string Calculate(IEnumerable<string> report)
        {
            var gamma = new GammaRateStrategy().Calculate(report);
            var result = new string(gamma.Select(bit => bit == '1' ? '0' : '1').ToArray());
            return result;
        }
    }
}
