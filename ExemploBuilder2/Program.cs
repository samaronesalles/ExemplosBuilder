using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder2.Classes;
using ExemploBuilder2.Builders;

namespace ExemploBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {

            BoloChocolate MeuBolo_DeChocolate = new BoloChocolateBuilder()
                .Acucar(3)
                .Farinha(2)
                .Chocolate(5)
                .Manteiga(1)
                .Ovos(2)
                .Build();

            BoloCenoura MeuBolo_DeCenoura = new BoloCenouraBuilder()
                .Cenouras(4)
                .Acucar(3)
                .Farinha(2)
                .Manteiga(1)
                .Ovos(2)
                .Build();

            Console.WriteLine("CENOURA : " + MeuBolo_DeCenoura.ToString());
            Console.WriteLine("CHOCOLATE : " + MeuBolo_DeChocolate.ToString());

            Console.ReadKey();


        }
    }
}
