using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder.Classes;

namespace ExemploBuilder.Director
{
    public interface BoloBuilder
    {
        BoloBuilder Chicaras_Farinha(double value);
        BoloBuilder Chicaras_Acucar(double value);
        BoloBuilder Chicaras_PoChocolate(double value);

        BoloBuilder Colheres_Manteiga(double value);
        BoloBuilder Colheres_Fermento(double value);

        BoloBuilder Cenouras(int value);
        BoloBuilder Ovos(int value);

        IBolo Build();
    }
}
