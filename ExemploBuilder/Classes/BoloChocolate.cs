using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder.Classes;

namespace ExemploBuilder.Builders
{
    class BoloChocolate : Bolo, IBolo
    {
        public BoloChocolate():base()
        {
            this.farinha = base.farinha;
            this.acucar = base.acucar;
            this.chocolate = base.chocolate;
            this.manteiga = base.manteiga;
            this.fermento = base.fermento;
            this.cenouras = base.cenouras;
            this.ovos = base.ovos;
        }
        
        public void SetQtdChicaras_Farinha(double value)
        {
            this.farinha = value;
        }

        public void SetQtdChicaras_Acucar(double value)
        {
            this.acucar = value;
        }

        public void SetQtdChicaras_PoChocolate(double value)
        {
            this.chocolate = value;
        }

        public void SetQtdColheres_Manteiga(double value)
        {
            this.manteiga = value;
        }

        public void SetQtdColheres_Fermento(double value)
        {
            this.fermento = value;
        }

        public void SetCenouras(int value)
        {
            this.cenouras = value;
        }

        public void SetOvos(int value)
        {
            this.ovos = value;
        }
    }
}
