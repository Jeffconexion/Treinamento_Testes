using Xunit;

namespace Demo.Tests
{
    public class AssertingObjectTypesTests
    {
        [Fact(DisplayName ="Verificando se o novo objeto é do tipo funcionário.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 10000);

            // Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact(DisplayName = "Verificando se o novo objeto é filho de funcionário.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 10000);

            // Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
