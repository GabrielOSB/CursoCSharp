using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpe.Fundamentos
{
    internal class VariaveisEFundamentos
    {
        public static void Executar()
        {
            // Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area= PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A soma é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo ? " +  estaChovendo);

            byte idade = 22;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; // Mais Usado dos inteiros !
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);
        }
    }
}
