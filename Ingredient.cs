using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeBogGrocery
{
    internal class Ingredient : ICloneable
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string cost { get; set; }
        public string location { get; set; }
        public string metric { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
