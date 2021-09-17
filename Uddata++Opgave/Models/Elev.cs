using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata__Opgave.Models
{
    
    class Elev : BaseClass
    {
        public int Advarsler { get; set; }
        public Klasse Klasse {  get; set; }
        public Dictionary<FagEnum, int> FagKarakter = new Dictionary<FagEnum, int>();
    }
}
