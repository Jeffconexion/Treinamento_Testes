using Xunit;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact(DisplayName = "Verificar se o nome não é nulo ou vazio.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
        {
            // Arrange & Act
            var funcionario = new Funcionario("", 1000);

            // Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact(DisplayName = "Verificar se apelido está com valor nullo.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Eduardo", 1000);

            // Assert
            Assert.Null(funcionario.Apelido);

            // Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}
