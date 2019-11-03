using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBuilder.Classes
{
    public abstract class Bolo
    {
        protected double farinha { get; set; }
        protected double acucar { get; set; }
        protected double chocolate { get; set; }
        protected double manteiga { get; set; }
        protected double fermento { get; set; }
        protected int cenouras { get; set; }
        protected int ovos { get; set; }

        public override string ToString()
        {
            return "{ \"farinha\": " + this.farinha + ", " +
                     "\"acucar\": " + this.acucar + ", " +
                     "\"chocolate\": " + this.chocolate + ", " +
                     "\"manteiga\": " + this.manteiga + ", " +
                     "\"fermento\": " + this.fermento + ", " +
                     "\"cenouras\": " + this.cenouras + ", " +
                     "\"ovos\": " + this.ovos + 
                  " }";
        }
    }
}
