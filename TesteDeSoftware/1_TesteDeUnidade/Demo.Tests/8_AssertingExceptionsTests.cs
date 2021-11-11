using System;
using Xunit;

namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact(DisplayName = "Validar excessão de valor divdido por zero.")]
        [Trait("Calculadora", "Soma, Divisão e Teorias")]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }


        [Fact(DisplayName = "Validar excessão para salário inferior ao permitido.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
        {
            // Arrange & Act & Assert
            var exception =
                Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Souza", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}
