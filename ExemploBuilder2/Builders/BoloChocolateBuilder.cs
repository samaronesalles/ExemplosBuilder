using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder2.Classes;

namespace ExemploBuilder2.Builders
{
    class BoloChocolateBuilder
    {
        private Bolo bolo;

        public BoloChocolateBuilder()
        {
            this.bolo = new Bolo();
        }

        public BoloChocolateBuilder Farinha(double value)
        {
            bolo.farinha = value;
            return this;
        }

        public BoloChocolateBuilder Acucar(double value)
        {
            bolo.acucar = value;
            return this;
        }

        public BoloChocolateBuilder Chocolate(double value)
        {
            bolo.chocolate = value;
            return this;
        }

        public BoloChocolateBuilder Manteiga(double value)
        {
            bolo.manteiga = value;
            return this;
        }

        public BoloChocolateBuilder Fermento(double value)
        {
            bolo.fermento = value;
            return this;
        }

        public BoloChocolateBuilder Cenouras(int value)
        {
            bolo.cenouras = value;
            return this;
        }

        public BoloChocolateBuilder Ovos(int value)
        {
            bolo.ovos = value;
            return this;
        }

        public BoloChocolate Build()
        {
            return new BoloChocolate(this.bolo);
        }
    }
}
