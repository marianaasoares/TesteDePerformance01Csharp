﻿using System;

namespace TesteDePerformance01_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo a calculadora de adição!");
            Console.WriteLine("Digite abaixo o primeiro número inteiro da operação");
            var primeiro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite abaixo o segundo número inteiro da operação");
            var segundo = double.Parse(Console.ReadLine());

            var result = primeiro + segundo;

            Console.WriteLine($"O seu resultado é: {result}");
        }
    }
}
