using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacsan
{
    internal class Patient : IHumen
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public int nationalnumber { get; set; }
        public bool sex { get; set; }
        public int phonenumber { get; set; }
        public string address { get; set; }
        public DateTime tarikhtavalod { get; set; }
        public string vacsinname { get; set; }
        public int does { get; set; }
        public DateTime dateDoes1 { get; set; }
        public DateTime dateDoes2 { get; set; }
        private void does2(DateTime does1) 
        {
            this.dateDoes2 = does1 + new TimeSpan(21,0,0,0,0);
        }
        public Patient(string name, string lastname, int nationalnumber, bool sex, int phonenumber, string address, DateTime tarikhtavalod , int does)
        {
            this.name = name;
            this.lastname = lastname;
            this.nationalnumber = nationalnumber;
            this.sex = sex;
            this.phonenumber = phonenumber;
            this.address = address;
            this.does = does;
            this.dateDoes1 = DateTime.Now;
            does2(dateDoes1);
        }

    }
}
