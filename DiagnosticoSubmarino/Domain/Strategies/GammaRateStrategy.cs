using DiagnosticoSubmarino.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoSubmarino.Domain.Strategies
{
    public class GammaRateStrategy : IBitCriteriaStrategy
    {
        public string Calculate(IEnumerable<string> report)
        {
            var bitLength = report.First().Length;
            var result = "";

            for (int i = 0; i < bitLength; i++)
            {
                var ones = report.Count(x => x[i] == '1');
                var zeros = report.Count() - ones;

                result += ones >= zeros ? '1' : '0';
            }

            return result;
        }
    }
}
