using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder2.Classes;

namespace ExemploBuilder2.Builders
{
    class BoloCenouraBuilder
    {
        private Bolo bolo;

        public BoloCenouraBuilder()
        {
            this.bolo = new Bolo();
        }

        public BoloCenouraBuilder Farinha(double value)
        {
            bolo.farinha = value;
            return this;
        }

        public BoloCenouraBuilder Acucar(double value)
        {
            bolo.acucar = value;
            return this;
        }

        public BoloCenouraBuilder Chocolate(double value)
        {
            bolo.chocolate = value;
            return this;
        }

        public BoloCenouraBuilder Manteiga(double value)
        {
            bolo.manteiga = value;
            return this;
        }

        public BoloCenouraBuilder Fermento(double value)
        {
            bolo.fermento = value;
            return this;
        }

        public BoloCenouraBuilder Cenouras(int value)
        {
            bolo.cenouras = value;
            return this;
        }

        public BoloCenouraBuilder Ovos(int value)
        {
            bolo.ovos = value;
            return this;
        }

        public BoloCenoura Build()
        {
            return new BoloCenoura(this.bolo);
        }

    }
}
