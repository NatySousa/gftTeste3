using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste3
{
    class Program
    {
        static void Main(string[] args)
        {
            Moradores m = new Moradores();
            Entregador e = new Entregador();

            int inicial = 0;

            while (inicial == 0)
            {
                Console.Write("Senhor(a) morador(a), sua residência tem cachorro - Sim ou Não:");
                var retorno = Console.ReadLine().ToLower();
                if (retorno == "sim")
                {
                    e.PossuiCachorro = true;
                }
                else
                {
                    Console.Write("Senhor(a) morador(a), informe seu numero de telefone: ");
                    m.Telefone = Console.ReadLine();
                    Console.Write("Senhor(a) morador(a), informe seu numero da residencia: ");
                    m.NumeroResidencia = Convert.ToInt32(Console.ReadLine());
                    e.AdicionarCasaImpar(m.NumeroResidencia);
                    Console.Write("Total de casas ímpares entregues " + e.ListaCasaImpar.Count());
                }

                Console.WriteLine("FAzer mais uma entrega? Sim ou Não");
                var resposta = Console.ReadLine().ToLower();
                if (resposta == "não")
                {
                    inicial = 1;
                }
            }


            Console.ReadKey();
        }
    }
}