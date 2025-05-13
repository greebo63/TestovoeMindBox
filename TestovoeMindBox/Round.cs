using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeMindBox
{
    public class Round : IFigure
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
                if (value >= 0)
                {
                    _radius = value;
                }
                else throw new Exception();
                 //не знал что делать при отрицательном радиусе, поэтому просто выкинул ошибку
            }
        }

        public Round(double radius)
        {
            this.radius = radius;
        }

        public double countArea()
        {
            double res = Math.PI * Math.Pow(_radius, 2);
            return res;
        }
    }
}
