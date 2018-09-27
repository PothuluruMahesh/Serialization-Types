using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    [Serializable]
    public class College
    {
        [NonSerialized]
        public int Ccode;
        public string Cname;
        public string Caddress;
        public int Cyear;

        public College(int i,string j,string k,int l)
        {
            this.Ccode = i;
            this.Cname = j;
            this.Caddress = k;
            this.Cyear = l;
        }
    }
}
