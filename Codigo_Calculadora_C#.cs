using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA EM C# ===");

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        char operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;
        bool valido = true;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("Erro: divisão por zero não é permitida.");
                    valido = false;
                }
                break;
            default:
                Console.WriteLine("Operador inválido.");
                valido = false;
                break;
        }

        if (valido)
            Console.WriteLine($"Resultado: {num1} {operador} {num2} = {resultado}");
    }
}
