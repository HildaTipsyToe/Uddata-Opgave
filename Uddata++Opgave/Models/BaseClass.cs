using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata__Opgave.Models
{
    
    abstract class BaseClass
    {

        public int ID { get; set; }
        public string Name {  get; set; }
        public List<Fag> fag = new List<Fag>();

    }
}
