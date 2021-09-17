using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata__Opgave.Models
{
    class Lærer : BaseClass
    {
        public bool Kaffeklubben{ get; set; }
        public List<Elev> klasser = new List<Elev>();
    }
}
