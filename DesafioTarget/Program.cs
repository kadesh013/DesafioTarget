using System;

class Program
{
    static void Main()
    {
        // Programa 1: Soma dos primeiros N números inteiros
        CalcularSoma();

        // Programa 2: Verificação de pertencimento à sequência de Fibonacci
        VerificarFibonacci();

        // Programa 5: Inversão de uma string
        InverterString();

        // Programa 4: Cálculo da porcentagem de faturamento por estado
        CalcularFaturamentoPorEstado();
    }

    // Programa 1: Soma dos primeiros N números inteiros
    static void CalcularSoma()
    {
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"Soma dos primeiros {indice} números inteiros: {soma}");
    }

    // Programa 2: Verificação de pertencimento à sequência de Fibonacci
    static void VerificarFibonacci()
    {
        int num1 = 0; // Primeiro número da sequência
        int num2 = 1; // Segundo número da sequência
        int proximoNumero = 0; // Próximo número da sequência

        Console.WriteLine("Digite um número inteiro para verificar se pertence à sequência de Fibonacci:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n == 0 || n == 1)
        {
            Console.WriteLine($"{n} pertence à sequência de Fibonacci.");
            return;
        }

        while (proximoNumero < n)
        {
            proximoNumero = num1 + num2;
            num1 = num2;
            num2 = proximoNumero;
        }

        if (proximoNumero == n)
        {
            Console.WriteLine($"{n} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{n} não pertence à sequência de Fibonacci.");
        }
    }

    // Programa 5: Inversão de uma string
    static void InverterString()
    {
        Console.WriteLine("Digite uma string para ser invertida:");
        string input = Console.ReadLine();

        string invertedString = Inverter(input);

        Console.WriteLine($"String invertida: {invertedString}");
    }

    static string Inverter(string str)
    {
        char[] inverted = new char[str.Length];
        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        {
            inverted[i] = str[j];
        }

        return new string(inverted);
    }

    // Programa 4: Cálculo da porcentagem de faturamento por estado
    static void CalcularFaturamentoPorEstado()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double totalFaturamento = sp + rj + mg + es + outros;

        double porcentagemSP = (sp / totalFaturamento) * 100;
        double porcentagemRJ = (rj / totalFaturamento) * 100;
        double porcentagemMG = (mg / totalFaturamento) * 100;
        double porcentagemES = (es / totalFaturamento) * 100;
        double porcentagemOutros = (outros / totalFaturamento) * 100;

        Console.WriteLine("Faturamento mensal por estado:");
        Console.WriteLine($"SP: R${sp:F2} - {porcentagemSP:F2}%");
        Console.WriteLine($"RJ: R${rj:F2} - {porcentagemRJ:F2}%");
        Console.WriteLine($"MG: R${mg:F2} - {porcentagemMG:F2}%");
        Console.WriteLine($"ES: R${es:F2} - {porcentagemES:F2}%");
        Console.WriteLine($"Outros: R${outros:F2} - {porcentagemOutros:F2}%");
    }
}
