using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeMindBox
{
    static class AreaCounter
    {
        public static double AreaCount(IFigure figure)
        {
            double res = figure.countArea();
            return res;
        }
    }
}
