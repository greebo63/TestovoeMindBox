using TestovoeMindBox;

namespace TestovoeMindBoxTests
{
    public class RoundTests
    {
        //тест подсчета радиуса у круга
        [Fact]
        public void countAreaofARoundWithRadius10()
        {
            //arrange
            double radius = 10;
            double expected = 314.1592653589793;
            //act
            Round round = new Round(radius);
            double actual = round.countArea();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void countAreaofARoundWithRadius0()
        {
            //arrange
            double radius = 0;
            double expected = 0;
            //act
            Round round = new Round(radius);
            double actual = round.countArea();
            //assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void countAreaofARoundWithRadius1()
        {
            //arrange
            double radius = 1;
            double expected = Math.PI;
            //act
            Round round = new Round(radius);
            double actual = round.countArea();
            //assert
            Assert.Equal(expected, actual);
        }


        //тест выбрасывания ошибки при присваивании радиусу отрицательного числа
        [Fact]
        public void checkExceptionWhenRadiusIsNegative()
        {
            //arrange
            double radius = -1;
            //act
            Exception exc = Record.Exception(() => { Round round = new Round(radius); });
            //assert
            Assert.NotNull(exc);
        }
    }
}