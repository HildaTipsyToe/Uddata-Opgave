using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata__Opgave.Models
{
    public enum FagEnum{Netværk, grundlæggende_programmering, OOP, Clientside }
    sealed public class Fag
    {
        public int FagID { get; set; }
        public FagEnum FagName { get; set; }
    }
        
}
