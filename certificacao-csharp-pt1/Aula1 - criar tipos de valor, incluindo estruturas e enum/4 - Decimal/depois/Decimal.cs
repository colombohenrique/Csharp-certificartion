using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subTotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subTotal);

            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subTotal = 30.30;

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subTotal);

            Console.WriteLine(valorProduto1 + valorProduto2);

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);

            decimal materiaPrima = 10.10m;
            decimal maoDeObra = 20.20m;
            decimal custo = 30.30m;

            Console.WriteLine("Descobrindo se 10.10m + 20.20m == 30.30m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);
        }
    }
}
