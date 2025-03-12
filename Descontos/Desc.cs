using System;
using System.Globalization;

namespace Salario.Descontos
{
    public class Desc
    {
        public static double inss7(double bruto)
        {
            return bruto * 0.075;
        }

        public static double inss9(double bruto)
        {
            return bruto * 0.09;
        }

        public static double inss12(double bruto)
        {
            return bruto * 0.12;
        }

        public static double inss14(double bruto)
        {
            return bruto * 0.14;
        }

        public static double descadc()
        {
            double descontoAdicional = 0;
            double x = 0;

            Console.WriteLine("Há desconto além do INSS?");
            Console.WriteLine("Caso haja, digite um por vez, se não basta digitar 0");

            do
            {

                Console.Write("Digite o valor do desconto: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                descontoAdicional += x;

            }
            while (x != 0);
            if (descontoAdicional > 0)
            {
                Console.WriteLine($"Valor dos descontos adicionais: {descontoAdicional.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sem valores adicionais para desconto");
                Console.WriteLine();
            }
            return descontoAdicional;

        }
    }
}