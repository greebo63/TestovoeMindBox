namespace TestovoeMindBox
{

    public class Triangle : IFigure
    {
        private double _firstEdge;
        private double _secondEdge;
        private double _thirdEdge;

        public double firstEdge 
        { 
            get 
            {
                return _firstEdge;
            }
            set
            {
                if (value > 0)
                {
                    _firstEdge = value;
                }
                else throw new Exception(); 
            }
        }
        public double secondEdge
        {
            get
            {
                return _secondEdge;
            }
            set
            {
                if (value > 0)
                {
                    _secondEdge = value;
                }
                else throw new Exception();
            }
        }

        public double thirdEdge
        {
            get
            {
                return _thirdEdge;
            }
            set
            {
                if (value > 0)
                {
                    _thirdEdge = value;
                }
                else throw new Exception();
            }
        }

        public Triangle(double firstEdge, double secondEdge, double thirdEdge)
        {
            //проверка существования треугольника: 1 сторона не должны быть больше/равна сумме остальных двух сторон и стороны не должны быть отрицательными
            if (isFigureRight(firstEdge, secondEdge, thirdEdge))
            {
                this.firstEdge = firstEdge;
                this.secondEdge = secondEdge;
                this.thirdEdge = thirdEdge;
            }
            else throw new Exception();
        }

        static public bool isFigureRight(double firstEdge, double secondEdge, double thirdEdge)
        {
            if (firstEdge < 0 || secondEdge < 0 || thirdEdge < 0)
            {
                return false;
            }

            double maxEdge = Math.Max(thirdEdge, Math.Max(firstEdge, secondEdge));
            if (maxEdge == thirdEdge)
            {
                if (thirdEdge >= firstEdge + secondEdge) return false;
            }
            else if (maxEdge == secondEdge)
            {
                if (firstEdge >= thirdEdge + secondEdge) return false;
            }
            else if (maxEdge == firstEdge)
            {
                if (secondEdge >= firstEdge + thirdEdge) return false;
            }
            return true;
        }

        public double countArea()
        {
            double res = 0;
            double p = (_firstEdge + _secondEdge + _thirdEdge) / 2;
            res = Math.Sqrt(p*(p-_firstEdge)*(p-_secondEdge)*(p-_thirdEdge));
            return res;
        }
        public bool isSquare()
        {
            //вычисление наибольшей стороны, чтобы не считать 3 разных комбинации теоремы Пифагора в одном if
            double maxEdge = Math.Max(_thirdEdge,Math.Max(_firstEdge, _secondEdge));

            if (maxEdge == _thirdEdge)
            {
                if (Math.Pow(_firstEdge, 2) + Math.Pow(_secondEdge, 2) == Math.Pow(_thirdEdge, 2))
                {
                    return true;
                }
            }
            else if (maxEdge == _secondEdge) 
            {
                if (Math.Pow(_firstEdge, 2) + Math.Pow(_thirdEdge, 2) == Math.Pow(_secondEdge, 2))
                {
                    return true;
                }
            }
            else if (maxEdge == _firstEdge)
            {
                if (Math.Pow(_secondEdge, 2) + Math.Pow(_thirdEdge, 2) == Math.Pow(_firstEdge, 2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
