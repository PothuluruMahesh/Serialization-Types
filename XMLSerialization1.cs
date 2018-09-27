using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    class XMLSerialization1
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Enter Roll No :");
            int i = Convert.ToInt32(Console.ReadLine());
            st.Sno = i;
            Console.WriteLine("Enter Your Name :");
            string j = Console.ReadLine();
            st.Sname = j;
            Console.WriteLine("Enter Your Address :");
            string k = Console.ReadLine();
            st.Address = k; 
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream(@"F:\JAVA\C#\SerializationWithPracties\Student121.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, st);
            fs.Close();
            Console.WriteLine("Data has been Serialized successfully via XML");
        }
    }
}
