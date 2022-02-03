using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;

            char resposta = 'S'; // System.Char

            byte nivelDeAzul = 0xFF; // = 255 em deciaml

            short passageirosVoo = 200; //System.Int16
            passageirosVoo = -7;

            int populacao = 1500; //System.Int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões - System.Int64

            sbyte nivelDeBrilho = -127; // System.SByte

            ushort passageirosNavio = 230; //System.UInt16

            uint estoque = 1500; //System.UInt32

            ulong populacaoDoMundo = 7_000_000_000; // 7 Bilhoes - System.UInt64

            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");


            //ATRIBUIÇÕES QUE CAUSAM ERROS
            //nivelDeAzul = 0xFFFF; // = 65535 em decimal 
            //passageirosVoo = 230000; //System.Int16
            //populacao = 15000000000; //System.Inte32
            //passageirosNavio = -15; // System.UInt16
            //estoque = -2300; // System.UInt32
            //populacaoDobrasil = 207_660_929.345;


        }
    }
}
