using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBuilder2.Classes
{
    class BoloCenoura: Bolo
    {
        public BoloCenoura(Bolo Builder)
        {
            this.farinha = Builder.farinha;
            this.acucar = Builder.acucar;
            this.chocolate = Builder.chocolate;
            this.manteiga = Builder.manteiga;
            this.fermento = Builder.fermento;
            this.cenouras = Builder.cenouras;
            this.ovos = Builder.ovos;
        }

    }
}
