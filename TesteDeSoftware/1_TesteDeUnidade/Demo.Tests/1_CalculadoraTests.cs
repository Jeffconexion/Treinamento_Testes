using Xunit;

/// <summary>
/// Esses teste de Unidade estão sendo cobertos pelos teste de Mutante.
/// 1 - Install stryker https://stryker-mutator.io/docs/stryker-net/Getting-started
/// 2 - Ir até a pasta de teste e executar dotnet-stryker
/// </summary>
namespace Demo.Tests
{
    public class CalculadoraTests
    {
        /// <summary>
        /// Eu tenho um Fato.
        /// O [Fact] atributo declara um método de teste que é executado pelo executor de teste.
        /// </summary>
        [Fact(DisplayName = "Calcular valor soma.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            //Assert.True(resultado == 4);
            Assert.Equal(4, resultado);
        }


        /// <summary>
        /// Eu tenho uma teoria, de modo que desejo realizar vários testes.
        /// O [Theory] representa um pacote de testes que executa o mesmo código, mas têm diferentes argumentos de entrada.
        /// </summary>
        /// <param name="v1">Primeiro Parâmetro</param>
        /// <param name="v2">Segundo Parâmetro</param>
        /// <param name="total">Valor total dos dois Parâmetros.</param>
        [Theory(DisplayName = "Teoria - Calcular valor soma.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        [InlineData(1, 1, 2)]
        [InlineData(3, 7, 10)]
        [InlineData(5, 2, 7)]
        [InlineData(-2, 1, -1)]
        [InlineData(4, 4, 8)]
        [InlineData(-1, 2, 1)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var reslutado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, reslutado);
        }

        [Theory(DisplayName = "Teoria - Calcular valor divisão.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(12, 4, 3)]
        [InlineData(6, 2, 3)]
        [InlineData(10, 2, 5)]
        [InlineData(10, 10, 1)]
        [InlineData(20, 4, 5)]
        public void Calculadora_Dividir_RetornarValoresDivisaoCorretos(int v1, int v2, int resultadoEsperado)
        {
            //Arrange
            var calculadora = new Calculadora();

            //ACT
            var resultado = calculadora.Dividir(v1, v2);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
