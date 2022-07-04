using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacsan
{
    internal class Vacsin
    {
        public string name
        {
            get; set;
        }
        public string contry
        {
            get; set;
        }
        public int doescount
        {
            get;set;
        }
        public Vacsin(string name, string contry, int doescount)
        {
            this.name = name;
            this.contry = contry;
            this.doescount = doescount;
        }
    }
}
