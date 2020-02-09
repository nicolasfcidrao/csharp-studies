using System;

namespace comandosBasicos
{
    class comandos
    {
        static void Main(string[] args)
        {
            var a = 8;
            var b = 4;
            var c = 5;

            System.Console.WriteLine($"Soma de inteiros = {soma(a, b)}");
            System.Console.WriteLine($"Soma de double = {somaDouble(a, b)}");

            System.Console.WriteLine("--------------------------------------------------------------------");

            System.Console.WriteLine($"Subtração de inteiros = {subtracao(a, b)}");
            System.Console.WriteLine($"Subtração de double = {subtracaoDouble(a, b)}");

            System.Console.WriteLine("--------------------------------------------------------------------");

            System.Console.WriteLine($"Multiplicação de inteiros = {multiplicacao(a, b)}");
            System.Console.WriteLine($"Multiplicação de double = {multiplicacaoDouble(a, b)}");

            System.Console.WriteLine("--------------------------------------------------------------------");

            System.Console.WriteLine($"Divisão de inteiros = {divisao(a, b)}");
            System.Console.WriteLine($"Divisão de double = {divisaoDouble(a, b)}");
            
            System.Console.WriteLine("--------------------------------------------------------------------");

            System.Console.WriteLine($"Ordem de operação de inteiros = {ordemOperacoes(a, b, c)}");
            System.Console.WriteLine($"Ordem de operação de double = {ordemOperacoesDouble(a, b, c)}");
            
        }

        static int ordemOperacoes(int a, int b, int c)
        {
            return (a + b) * c;
        }
        static int soma(int a, int b)
        {
            return a + b;
        }
        static int subtracao(int a, int b)
        {
            return a - b;
        }
        static int multiplicacao(int a, int b)
        {
            return a * b;
        }
        static int divisao(int a, int b)
        {
            return a / b;
        }
        static double ordemOperacoesDouble(double a, double b, double c)
        {
            return (a + b) / c;
        }
        static double somaDouble(double a, double b)
        {
            return a + b;
        }
        static double subtracaoDouble(double a, double b)
        {
            return a - b;
        }
        static double multiplicacaoDouble(double a, double b)
        {
            return a * b;
        }
        static double divisaoDouble(double a, double b)
        {
            return a / b;
        }

    }
}