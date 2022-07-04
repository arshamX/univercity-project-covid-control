using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacsan
{
    public class Admin : IHumen
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public int nationalnumber { get; set; }
        public bool sex { get; set; }
        public int phonenumber { get; set; }
        public string address { get; set; }
        public DateTime tarikhtavalod { get; set; }
        public string userName{ set; get; }
        public string password { set; get; }


        public Admin(string name , string lastname, int nationalnumber, bool sex, int phonenumber, string address, DateTime tarikhtavalod, string userName, string password)
        {
            this.name = name;
            this.lastname = lastname;
            this.nationalnumber = nationalnumber;
            this.sex = sex;
            this.phonenumber = phonenumber;
            this.address = address;
            this.userName = userName;
            this.password = password;
        }
    }
}
