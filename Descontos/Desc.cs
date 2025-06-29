using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Salario.Descontos
{
    public class Desc
    {
        static double salario1 = 1518.00;
        static double salario2 = 2793.88;
        static double salario3 = 4190.85;
        static double descontoinss = salario1 * 0.075;

        public static double inss7(double bruto)
        {
            return bruto * 0.075;
        }

        public static double inss9(double bruto)
        {
            double salario = (bruto - salario1) * 0.09;
            return salario + descontoinss;
        }

        public static double inss12(double bruto)
        {
            double descnove = (salario2 - salario1) * 0.09;
            double salario = (bruto - salario2) * 0.12;
            return salario + descnove + descontoinss;

        }

        public static double inss14(double bruto)
        {
            double descnove = (salario2 - salario1) * 0.09;
            double descdoze = (salario3 - salario2) * 0.12;
            double salario = (bruto - salario3) * 0.14;
            return salario + descnove + descdoze + descontoinss;
        }

        public static double descadc()
        {
            string input;
            double descontoAdicional = 0;
            double x = 0;

            Console.WriteLine("Há desconto além do INSS?");
            Console.WriteLine("Caso haja, digite um por vez, se não basta digitar 0");

            do
            {
                Console.Write("Digite o valor do desconto: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input != "0")
                {
                    x = double.Parse(input, CultureInfo.InvariantCulture);
                    descontoAdicional += x;
                }
            }
            while (!string.IsNullOrWhiteSpace(input) && input != "0");
            
            if (descontoAdicional == 0)
            {
                Console.WriteLine("Sem mais valores para desconto");
                Console.WriteLine();
            }
            return descontoAdicional;

        }
    }
}