using System;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    class XMLDeserializable
    {
        public static void Main(string[] args)
        {
            
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream(@"F:\JAVA\C#\SerializationWithPracties\Student.xml", FileMode.Open,FileAccess.Read);
            Student st = (Student)xs.Deserialize(fs);
            Console.WriteLine("Student No :" + st.Sno);
            Console.WriteLine("Student Name :" + st.Sname);
            Console.WriteLine("Student Address :" + st.Address);
            fs.Close();

        }
    }
}
