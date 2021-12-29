using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class AssertNumbersTests
    {
        [Fact(DisplayName = "Soma deve ser igual ao valor esperado.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        public void Calculadora_Somar_DeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(1, 2);

            // Assert
            //Assert.Equal(3, result);
            result.Should().Be(3);
        }

        [Fact(DisplayName = "Soma não deve ser igual ao valor esperado.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        public void Calculadora_Somar_NaoDeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(1.1, 2.2);

            // Assert
            //Assert.NotEqual(3.3, result, 1);
            result.Should().NotBe(2);
        }
    }
}
