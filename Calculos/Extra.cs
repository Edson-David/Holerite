namespace Salario.Calculos
{
    public class Extra
    {
        static double Hora, ValorHora, He = 0;
        static double He100 = 0;

        public static double horas(double salario, int HorasTrabalhadas)
        {
            Console.WriteLine("Quantas horas extras a 50% foram feitas este mês?");

            if (HorasTrabalhadas == 44)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 220;
                He = ValorHora * Hora * 1.5;
            }
            else if (HorasTrabalhadas == 40)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 200;
                He = ValorHora * Hora * 1.5;
            }
            else if (HorasTrabalhadas == 36)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 180;
                He = ValorHora * Hora * 1.5;
            }
            return He;
        }

        public static double horas100(double salario, int HorasTrabalhadas)
        {
            Console.WriteLine("Quantas horas extras a 100% foram feitas este mês?");

            if (HorasTrabalhadas == 44)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 220;
                He100 = ValorHora * Hora * 2;
            }
            else if (HorasTrabalhadas == 40)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 200;
                He100 = ValorHora * Hora * 2;
            }
            else if (HorasTrabalhadas == 36)
            {
                Hora = double.Parse(Console.ReadLine());
                ValorHora = salario / 180;
                He100 = ValorHora * Hora * 2;
            }
            return He100;
        }

    }
}
