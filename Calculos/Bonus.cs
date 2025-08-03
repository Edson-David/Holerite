using System;
using System.Globalization;

namespace Salario.Bonus
{
    public class Adicionais
    {
        static string input;
        static double x = 0;
        static double adc = 0;

        public static double adicional()
        {
            Console.WriteLine("Caso haja mais de um valor digite um por vez");
            Console.WriteLine("Basta digitar 0 quando não houver mais valores");
            do
            {
                Console.Write("Digite o valor: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input != "0")
                {
                    x = double.Parse(input, CultureInfo.InvariantCulture);
                    adc += x;
                }
            }
            while (!string.IsNullOrWhiteSpace(input) && input != "0");

            return adc;
        }
    }
}