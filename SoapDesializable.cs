using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    class SoapDesializable
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\JAVA\C#\SerializationWithPracties\College.xml",FileMode.Open,FileAccess.Read);
            SoapFormatter af = new SoapFormatter();
            College cl = (College)af.Deserialize(fs);
            Console.WriteLine("---------------The SOAP Deserialized Data Is--------------");
            Console.WriteLine("College Code :"+cl.Ccode);
            Console.WriteLine("College Name :" + cl.Cname);
            Console.WriteLine("College Address :" + cl.Caddress);
            Console.WriteLine("College Start Year :" + cl.Cyear);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("SOAP Deserialization is successfully Done");
        }
    }
}
