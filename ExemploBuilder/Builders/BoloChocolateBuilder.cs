using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBuilder.Classes;
using ExemploBuilder.Director;

namespace ExemploBuilder.Builders
{
    public class BoloChocolateBuilder : BoloBuilder
    {
        private IBolo bolo;

        public BoloChocolateBuilder()
        {
            this.bolo = new BoloCenoura();
        }

        public static BoloCenouraBuilder builder()
        {
            return new BoloCenouraBuilder();
        }

        public BoloBuilder Chicaras_Farinha(double value)
        {
            this.bolo.SetQtdChicaras_Farinha(value);
            return this;
        }

        public BoloBuilder Chicaras_Acucar(double value)
        {
            this.bolo.SetQtdChicaras_Acucar(value);
            return this;
        }

        public BoloBuilder Chicaras_PoChocolate(double value)
        {
            this.bolo.SetQtdChicaras_PoChocolate(value);
            return this;
        }

        public BoloBuilder Colheres_Manteiga(double value)
        {
            this.bolo.SetQtdColheres_Manteiga(value);
            return this;
        }

        public BoloBuilder Colheres_Fermento(double value)
        {
            this.bolo.SetQtdColheres_Fermento(value);
            return this;
        }

        public BoloBuilder Cenouras(int value)
        {
            this.bolo.SetCenouras(value);
            return this;
        }

        public BoloBuilder Ovos(int value)
        {
            this.bolo.SetOvos(value);
            return this;
        }

        public IBolo Build()
        {
            return this.bolo;
        }
    }
}
