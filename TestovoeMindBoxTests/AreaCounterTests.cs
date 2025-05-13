using TestovoeMindBox;

namespace TestovoeMindBoxTests
{
    public class AreaCounterTests
    {

        //тест метода areaCount с разными IFigure
        [Fact]
        public void roundAreaCount()
        {
            //arrange
            double radius = 10;
            Round round = new Round(radius);
            double expected = 314.1592653589793;
            //act
            double actual = AreaCounter.areaCount(round);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void triangleAreaCount()
        {
            //arrange
            double firstEdge = 3;
            double secondEdge = 4;
            double thirdEdge = 5;
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);
            double expected = 6;
            //act
            double actual = AreaCounter.areaCount(triangle);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
