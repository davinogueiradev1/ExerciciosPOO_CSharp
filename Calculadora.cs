using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Calculadora
    {
        public decimal soma { get; set; }
        public decimal subtrair { get; set; }
        public decimal multiplicar { get; set; }
        public static decimal dividir { get; set; }
        public void Somar (decimal valor1, decimal valor2)
        {
            soma = valor1 + valor2;
            Console.WriteLine($"O valor da soma dos valores é: {soma}");
        }
        public void Subtrair (decimal valor1, decimal valor2)
        {
            subtrair = valor1 - valor2;
            Console.WriteLine($"O valor da subtração dos valores é: {subtrair}");
        }
        public void Multiplicacao (decimal valor1, decimal valor2)
        {
            multiplicar = valor1 * valor2;
            Console.WriteLine($"O valor da multiplicação dos valores é: {multiplicar}");
        }

        public static void Divisao(decimal valor1, decimal valor2)
        {
            dividir = valor1 / valor2;
            Console.WriteLine($"O valor da divisão dos valores é: {dividir}");
        }
    }
}