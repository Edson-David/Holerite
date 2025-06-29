using System.Globalization;
using Salario.Descontos;

CultureInfo CI = CultureInfo.InvariantCulture;

double liquido, salario, inss, bruto = 0;
double x = 0;

Console.WriteLine("      Salário             Desconto %");
Console.WriteLine("Até 1518.00                  7.50%");
Console.WriteLine("De 1518.01 até 2793.88       9.00%");
Console.WriteLine("De 2793.89 até 4190.84      12.00%");
Console.WriteLine("De 4190.85 até 8157.41      14.00%");

Console.Write("Digite seu salário: ");
    salario = double.Parse(Console.ReadLine(), CI);

    Console.WriteLine();

    Console.WriteLine("Há algum beneficio pago em folha?");
    Console.WriteLine("Caso haja, digite um por vez, se não basta digitar 0");

    string input;
    do
    {
        Console.Write("Digite o valor: ");
        input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && input != "0")
        {
            x = double.Parse(input, CI);
            bruto += x;
        }
    }

    while (!string.IsNullOrWhiteSpace(input) && input != "0");

    bruto += salario;

    double descontoAdicional = Desc.descadc();


if (salario <= 1518)
{
    Console.WriteLine("Desconto do INSS é de 7.5%");
    inss = Desc.inss7(bruto);
    liquido = bruto - inss - descontoAdicional;
    Console.WriteLine($"O desconto do INSS ficou em: R$ {inss.ToString("F2", CI)}");
    if (descontoAdicional > 0)
    {
        Console.WriteLine($"Valor dos descontos adicionais: {descontoAdicional.ToString("F2", CI)}");
    }
    Console.WriteLine($"Seu salário liquido é de: R$ {liquido.ToString("F2", CI)}");
}

else if (salario >= 1518.01 && salario <= 2793.88)
{
    Console.WriteLine("Desconto do INSS é de 9%");
    inss = Desc.inss9(bruto);
    liquido = bruto - inss - descontoAdicional;
    Console.WriteLine($"O desconto do INSS ficou em: R$ {inss.ToString("F2", CI)}");
    if (descontoAdicional > 0)
    {
        Console.WriteLine($"Valor dos descontos adicionais: {descontoAdicional.ToString("F2", CI)}");
    }
    Console.WriteLine($"Seu salário liquido é de: R$ {liquido.ToString("F2", CI)}");
}

else if (salario >= 2793.89 && salario <= 4190.84)
{
    Console.WriteLine("Desconto do INSS é de 12%");
    inss = Desc.inss12(bruto);
    liquido = bruto - inss - descontoAdicional;
    Console.WriteLine($"O desconto do INSS ficou em: R$ {inss.ToString("F2", CI)}");
    Console.WriteLine($"Seu salário liquido é de: R$ {liquido.ToString("F2", CI)}");
}

else if (salario >= 4190.84 && salario <= 8157.41)
{
    Console.WriteLine("Desconto do INSS é de 14%");
    inss = Desc.inss14(bruto);
    liquido = bruto - inss - descontoAdicional;
    Console.WriteLine($"O desconto do INSS ficou em: R$ {inss.ToString("F2", CI)}");
    if (descontoAdicional > 0)
    {
        Console.WriteLine($"Valor dos descontos adicionais: {descontoAdicional.ToString("F2", CI)}");
    }
    Console.WriteLine($"Seu salário liquido é de: R$ {liquido.ToString("F2", CI)}");
}

else
{
    Console.WriteLine("Cê ganha pra krl hein bixão");
}