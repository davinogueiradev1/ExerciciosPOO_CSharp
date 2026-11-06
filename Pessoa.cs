using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int? idade { get; set; }
        public string? Cidade { get; set; }

        public void Apresentar ()
        {
            Console.WriteLine($"O nome do aluno é {Nome}.\n{Nome} tem {idade} anos e mora em {Cidade}");
        }

    }

    
}