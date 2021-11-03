﻿using Xunit;

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
        [Fact]
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
        [Theory]
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
    }
}