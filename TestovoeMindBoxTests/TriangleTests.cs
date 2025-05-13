using TestovoeMindBox;

namespace TestovoeMindBoxTests
{
    public class TriangleTests
    {

        //тест метода countArea
        [Fact]
        public void countAreaFirstEdge3SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = 3;
            double secondEdge = 4;
            double thirdEdge = 5;
            double expected = 6;
            //act
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);
            double actual = triangle.countArea();
            //assert
            Assert.Equal(expected, actual);
        }
        //тест метода isSquare
        [Fact]
        public void checkTriangleIsSquareTrueFirstEdge3SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = 3;
            double secondEdge = 4;
            double thirdEdge = 5;
            bool expected = true;
            //act
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);
            bool actual = triangle.isSquare();
            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void checkTriangleIsSquareFalseFirstEdge3SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = 2;
            double secondEdge = 4;
            double thirdEdge = 5;
            bool expected = false;
            //act
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);
            bool actual = triangle.isSquare();
            //assert
            Assert.Equal(expected, actual);
        }
        //тест метода isFigureRight
        [Fact]
        public void checkIsFigureRightFalseFirstEdge1SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = 1;
            double secondEdge = 4;
            double thirdEdge = 5;
            //act
            bool actual = Triangle.isFigureRight(firstEdge, secondEdge, thirdEdge);
            //assert
            Assert.False(actual);
        }
        [Fact]
        public void checkIsFigureRightFalseFirstEdgeMinus1SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = -1;
            double secondEdge = 4;
            double thirdEdge = 5;
            //act
            bool actual = Triangle.isFigureRight(firstEdge, secondEdge, thirdEdge);
            //assert
            Assert.False(actual);
        }

        [Fact]
        public void checkIsFigureRightTrueFirstEdge2SecondEdge4ThirdEdge5()
        {
            //arrange
            double firstEdge = 2;
            double secondEdge = 4;
            double thirdEdge = 5;
            //act
            bool actual = Triangle.isFigureRight(firstEdge, secondEdge, thirdEdge);
            //assert
            Assert.True(actual);
        }
        //тест ошибок при присваивании firstEdge отрицательного значения
        [Fact]
        public void checkExceptionWhenFirstEdgeIsNegative()
        {
            //arrange
            double firstEdge = 2;
            double secondEdge = 4;
            double thirdEdge = 5;
            //act
            Exception ex = Record.Exception(()=> 
            {
                Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);
                triangle.firstEdge = -2;
            });
            //assert
            Assert.NotNull(ex);
        }
    }
}
