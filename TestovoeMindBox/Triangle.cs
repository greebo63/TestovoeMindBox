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
                _firstEdge = value;
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
                _secondEdge = value;
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
                _thirdEdge = value;
            }
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
