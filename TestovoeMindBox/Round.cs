using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeMindBox
{
    class Round : IFigure
    {
        private double _radius;

        public double radius
        {
            get 
            { 
                return _radius; 
            }
            set 
            { 
                _radius = value; 
            }
        }
        public double countArea()
        {
            double res = Math.PI * Math.Pow(_radius, 2);
            return res;
        }
    }
}
