﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            idade = (int)15.5f;

            //int massa = 6_000000_000000_000000_000000;
            //long massa = 6e24;

            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.9736e24f; //System.Double
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            float numeroPI = 3.14159f; //System.Single
            Console.WriteLine($"numeroPI: {numeroPI}");

            //atribuição excede limite float
            //float numeroMuitoMaior = 6e100f;

            double numeroMuitoMaior = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine($"O resultado é do tipo: {resultado1.GetType()}");


            float z = 4.5f;
            var resultado2 = (x * y) / z;
            Console.WriteLine("(x * y) / z = {0}", resultado2);
            Console.WriteLine($"O resultado é do tipo: {resultado2.GetType()}");

        }
    }
}
