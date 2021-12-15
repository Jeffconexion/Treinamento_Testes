using System;
using System.Collections.Generic;

namespace Demo
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; private set; }
        public EnumNivelProfissional NivelProfissional { get; private set; }
        public IList<string> Habilidades { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = string.IsNullOrEmpty(nome) ? "Fulano" : nome;
            DefinirSalario(salario);
            DefinirHabilidades();
        }

        public void DefinirSalario(double salario)
        {
            if (salario < 500)
                throw new Exception("Salario inferior ao permitido");

            Salario = salario;
            if (salario < 2000)
                NivelProfissional = EnumNivelProfissional.Junior;
            if (salario >= 2000 && salario <= 8000)
                NivelProfissional = EnumNivelProfissional.Pleno;
            if (salario > 8000)
                NivelProfissional = EnumNivelProfissional.Senior;
        }

        private void DefinirHabilidades()
        {
            var habilidadesBasicas = new List<string>()
            {
                "Lógica de Programação",
                "OOP"
            };

            Habilidades = habilidadesBasicas;

            switch (NivelProfissional)
            {
                case EnumNivelProfissional.Pleno:
                    Habilidades.Add("Testes");
                    break;
                case EnumNivelProfissional.Senior:
                    Habilidades.Add("Testes");
                    Habilidades.Add("Microservices");
                    break;
            }
        }
    }
}
