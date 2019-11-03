using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBuilder.Classes
{
    public interface IBolo
    {
        void SetQtdChicaras_Farinha(double value);
        void SetQtdChicaras_Acucar(double value);
        void SetQtdChicaras_PoChocolate(double value);

        void SetQtdColheres_Manteiga(double value);
        void SetQtdColheres_Fermento(double value);

        void SetCenouras(int value);
        void SetOvos(int value);
    }
}
