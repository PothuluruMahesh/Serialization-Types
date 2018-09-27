using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    [Serializable]
    public class Program
    {
        public int Id;
       // [NonSerialized]
        public string Name; 
        public int Age; 
        public Program(int id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
