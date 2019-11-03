using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBuilder2.Classes
{
    public class Bolo
    {
        public double farinha { get; set; }
        public double acucar { get; set; }
        public double chocolate { get; set; }
        public double manteiga { get; set; }
        public double fermento { get; set; }
        public int cenouras { get; set; }
        public int ovos { get; set; }

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
