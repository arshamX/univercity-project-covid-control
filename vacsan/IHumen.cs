using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacsan
{
    internal interface IHumen
    {
        string name { get; set; }
        string lastname { get; set; }
        int nationalnumber { get; set; }
        bool sex { get; set; }
        int phonenumber { get; set; }
        string address { get; set; }
        DateTime tarikhtavalod { get; set; }

    }
}
