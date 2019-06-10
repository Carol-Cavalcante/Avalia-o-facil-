using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carol_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;


            do
            {
                Console.WriteLine("Deseja comprar algum item?  ");

                resposta = Console.ReadLine();

                Console.WriteLine("Compra realizada com sucesso! ");
            }
            while (resposta == "sim");


            Console.WriteLine("Programa finalizado! ");
        }
    }

        }
    

