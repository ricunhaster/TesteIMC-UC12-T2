using TesteIMC_BET2;
using Xunit;

namespace TestXUnityIMC
{
    public class UnitTest1
    {
        [Fact]
        public void CalculoIMC()
        {
            //Arrange
            double peso = 100;
            double altura = 2;
            double resultadoEsperado = 25;

            //Act
            var resultado = Operacoes.CalculaIMC(peso, altura);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(100, 2, 25)]
        [InlineData(90, 1.5 ,40)]
        [InlineData(50, 1.8 ,16)]
        [InlineData(10, 0, 0)]

        public void CalculoIMC_RetornoResultdo_Multiplos(double peso, double altura, double imc)
        {
            //Act
            var resultado = Operacoes.CalculaIMC(peso, altura);

            //Assert
            Assert.Equal(imc, resultado);

        }
    }
}