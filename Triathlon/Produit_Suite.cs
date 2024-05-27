using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon
{
    public partial class PRODUIT
    {
        public override string ToString()
        {
            return this.codeProduit + " - " + this.libelle;
        }
    }
}
