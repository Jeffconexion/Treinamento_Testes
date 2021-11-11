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
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact(DisplayName = "Habilidades que o junior deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 1000);

            // Assert
            Assert.Contains("OOP", funcionario.Habilidades);
        }


        [Fact(DisplayName = "Habilidades que o junior não deve possuir.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Souza", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
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
            Assert.Equal(habilidadesBasicas, funcionario.Habilidades);
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
            Assert.Equal(habilidadesBasicas, funcionario.Habilidades);
        }
    }
}
