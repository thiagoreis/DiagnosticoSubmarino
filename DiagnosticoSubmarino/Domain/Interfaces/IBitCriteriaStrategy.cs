using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoSubmarino.Domain.Interfaces
{
    public interface IBitCriteriaStrategy
    {
        string Calculate(IEnumerable<string> report);
    }
}
