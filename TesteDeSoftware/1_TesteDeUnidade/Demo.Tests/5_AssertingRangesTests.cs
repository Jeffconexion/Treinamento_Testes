using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class AssertingRangesTests
    {
        [Theory(DisplayName = "Verificar faixa salarial corresponde ao nível profissional.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        [InlineData(500)]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(3000)]
        [InlineData(7500)]
        [InlineData(7999)]
        [InlineData(8000)]
        [InlineData(10000)]
        [InlineData(15000)]
        public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(double salario)
        {
            // Arrange & Act
            var funcionario = new Funcionario("Carlos", salario);

            // Assert
            if (funcionario.NivelProfissional == EnumNivelProfissional.Junior)
                Assert.InRange(funcionario.Salario, 500, 1999);

            if (funcionario.NivelProfissional == EnumNivelProfissional.Pleno)
                Assert.InRange(funcionario.Salario, 2000, 8000);

            if (funcionario.NivelProfissional == EnumNivelProfissional.Senior)
                Assert.InRange(funcionario.Salario, 8001, double.MaxValue);

            //Assert.NotInRange(funcionario.Salario, 0, 499);
            funcionario.Salario.Should().NotBeInRange(0, 499);
        }
    }
}
