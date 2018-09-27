using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    class Serializable1
    {
        
        public void SerializationMethod()
        {
            Program pr = new Program(102, "Mahesh", 23);
            FileStream fs = new FileStream(@"F:\JAVA\C#\SerializationWithPracties\Mahesh.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, pr);
            fs.Close();
            Console.WriteLine("Serialization successfully completed");
        }
        public void DeSerializationMethod()
        {
            
            FileStream fs = new FileStream(@"F:\JAVA\C#\SerializationWithPracties\Mahesh.txt", FileMode.Open,FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Program pr = (Program)formatter.Deserialize(fs);
            fs.Close();
            Console.WriteLine("DeSerialization successfully completed\n");
            Console.WriteLine("----------------The file Data Is--------------");
            Console.WriteLine("Student Id :" + pr.Id + "\nStudent Name :" + pr.Name + "\nStudent Age :" + pr.Age);
            Console.WriteLine("----------------The file END--------------");
            Console.WriteLine("\nYOU Done Serialization AND DeSerialization successfully\n");
            Console.WriteLine("The file storage Path is :"+ @"F:\JAVA\C#\SerializationWithPracties\Mahesh.txt");
        }
        static void Main(string[] args)
        {
            Serializable1 serializable = new Serializable1();
            serializable.SerializationMethod();
            Console.WriteLine("======================================================");
            Thread.Sleep(3000);
            Console.WriteLine("If you want to Deserialize it then enter (Y/y)");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch == 'y' || ch == 'Y')
            {
                serializable.DeSerializationMethod();
            }
            else
            {
                Console.WriteLine("\nYou Done Serialization only");
            }
        }
    }
}
