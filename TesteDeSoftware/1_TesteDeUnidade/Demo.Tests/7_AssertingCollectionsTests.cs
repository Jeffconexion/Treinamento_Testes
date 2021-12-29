using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact(DisplayName = "Habilidades não devem ter valor nulo.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 10000);

            // Assert
            //Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
            funcionario.Habilidades.Should().NotBeNullOrEmpty();
        }

        [Fact(DisplayName = "Habilidades que o junior deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 1000);

            // Assert
            //Assert.Contains("OOP", funcionario.Habilidades);
            funcionario.Habilidades.Should().Contain("OOP").And.Contain("Lógica de Programação");
        }


        [Fact(DisplayName = "Habilidades que o junior não deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 1000);

            // Assert
            //Assert.DoesNotContain("Microservices", funcionario.Habilidades);

            funcionario.Habilidades.Should().NotContain("Microservices").And.NotContain("Testes");

        }

        [Fact(DisplayName = "Habilidades que o pleno deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_PlenoDevePossuirHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 5000);

            var habilidadesBasicas = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes"
            };

            // Assert
            //Assert.Equal(habilidadesBasicas, funcionario.Habilidades);

            funcionario.Habilidades.Should().Equals(habilidadesBasicas);
        }


        [Fact(DisplayName = "Habilidades que o nível senior deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 15000);

            var habilidadesBasicas = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            // Assert
            //Assert.Equal(habilidadesBasicas, funcionario.Habilidades);

            funcionario.Habilidades.Should().Equals(habilidadesBasicas);

        }
    }
}
