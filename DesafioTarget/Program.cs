using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Escolha um programa para executar:");
            Console.WriteLine("1. Calcular a soma dos primeiros N números inteiros");
            Console.WriteLine("2. Verificar se um número pertence à sequência de Fibonacci");
            Console.WriteLine("3. Inverter uma string");
            Console.WriteLine("4. Calcular a porcentagem de faturamento por estado");
            Console.WriteLine("5. Sair");
            Console.Write("Digite o número do programa desejado: ");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    ExibirSoma();
                    break;
                case 2:
                    VerificarFibonacci();
                    break;
                case 3:
                    InverterString();
                    break;
                case 4:
                    CalcularFaturamentoPorEstado();
                    break;
                case 5:
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
            }

            if (opcao != 5)
            {
                Console.WriteLine("Deseja retornar ao menu principal? (s/n): ");
                char resposta = Console.ReadKey().KeyChar;
                if (resposta != 's' && resposta != 'S')
                {
                    continuar = false;
                }
            }
        }
    }

    static void ExibirSoma()
    {
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"\nO valor da variável SOMA é: {soma}");
    }

    static void VerificarFibonacci()
    {
        int num1 = 0;
        int num2 = 1;
        int proximoNumero = 0;

        Console.WriteLine("Digite um número inteiro para verificar se pertence à sequência de Fibonacci:");
        int n;

        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Entrada inválida. O número deve ser um inteiro não negativo.");
            return;
        }

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

        Console.WriteLine("\nFaturamento mensal por estado:");
        Console.WriteLine($"SP: R${sp:F2} - {porcentagemSP:F2}%");
        Console.WriteLine($"RJ: R${rj:F2} - {porcentagemRJ:F2}%");
        Console.WriteLine($"MG: R${mg:F2} - {porcentagemMG:F2}%");
        Console.WriteLine($"ES: R${es:F2} - {porcentagemES:F2}%");
        Console.WriteLine($"Outros: R${outros:F2} - {porcentagemOutros:F2}%");
    }
}
