using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder.Classes;
using ExemploBuilder.Builders;
using ExemploBuilder.Director;

namespace ExemploBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBolo MeuBolo_DeChocolate = BoloChocolateBuilder.builder()  // Aqui eu não passo valor para "Cenouras"
                .Chicaras_Acucar(3)
                .Chicaras_Farinha(2)
                .Chicaras_PoChocolate(5)
                .Colheres_Manteiga(1)
                .Ovos(2)
                .Build();

            IBolo MeuBolo_DeCenoura = BoloCenouraBuilder.builder()     // Aqui eu não passo valor para "Chocolate"
                .Cenouras(4)
                .Chicaras_Acucar(3)
                .Chicaras_Farinha(2)
                .Colheres_Manteiga(1)
                .Ovos(2)
                .Build();

            Console.WriteLine("CENOURA : " + MeuBolo_DeCenoura.ToString());
            Console.WriteLine("CHOCOLATE : " + MeuBolo_DeChocolate.ToString());

            Console.ReadKey();
        }
    }
}
