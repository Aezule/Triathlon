using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon
{
    public partial class TRIATHLON
    {
        public override string ToString()
        {
            return this.numTriathlon + " - " +  this.nom + " - " + this.lieu;
        }
    }
}
