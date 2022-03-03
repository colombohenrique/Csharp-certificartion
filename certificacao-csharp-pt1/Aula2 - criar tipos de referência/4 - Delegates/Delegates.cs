using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._4___Delegates
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

            //instancia de um delegate com um metódo anônimo
            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine("quadrado: {0}", quadrado);

            //instancia de um delegate com uma expressão lambda
            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoCubo(4.375);

            Console.WriteLine("cubo: {0}", cubo);
        }
    }

    }
}
