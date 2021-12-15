using Xunit;

namespace Demo.Tests
{
    /// <summary>
    /// Aplicando testes em propriedades do tipo strings.
    /// </summary>
    public class AssertStringsTests
    {
        [Fact(DisplayName = "Retornar nome completo.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Carlos", "Souza");

            // Assert
            Assert.Equal("Carlos Souza", nomeCompleto);
        }


        [Fact(DisplayName = "Retornar nome ignorando case.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("carlos", "souza");

            // Assert
            Assert.Equal("CARLOS SOUZA", nomeCompleto, true);
        }


        [Fact(DisplayName = "Retornar nome com trecho específico.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Carlos", "Souza");

            // Assert
            Assert.Contains("rlo", nomeCompleto);
        }


        [Fact(DisplayName = "Retornar nome começando com trecho específico.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Carlos", "Souza");

            // Assert
            Assert.StartsWith("Car", nomeCompleto);
        }


        [Fact(DisplayName = "Retornar nome acabando com trecho específico.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Carlos", "Souza");

            // Assert
            Assert.EndsWith("za", nomeCompleto);
        }

        [Fact(DisplayName = "Validar expressão regular para os nomes.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Carlos", "Souza");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }

        [Theory(DisplayName = "Teoria - Validar expressão regular.")]
        [Trait("Funcionário", "Testando os nomes e Teorias.")]
        [InlineData("Charlotte", "Valadares ", "Charlotte Valadares ")]
        [InlineData("Quelia", "Costa  ", "Quelia Costa  ")]
        [InlineData("Nadine", "Lage ", "Nadine Lage ")]
        public void StringsTools_UnirNomes_ValidarMuitasExpressoesRegular(string Nome, string SobreNome, string resultado)
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var resultadoNomeCompleto = sut.Unir(Nome, SobreNome);

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", resultadoNomeCompleto);
            Assert.Equal(resultado, resultadoNomeCompleto);

        }
    }
}
