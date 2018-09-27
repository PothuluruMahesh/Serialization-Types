using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWithPracties
{
    public class OldKey
    {
        public static void Test1()
        {
            Console.WriteLine("I AM From Test1 in NewKey class");
        }
        public static void Test2()
        {
            Console.WriteLine("I AM From Test2 in NewKey class");
        }
    }
    public class NewKey : OldKey
    {
        public static  void Test1()
        {
            Console.WriteLine("I AM From Test1 in NewKey class");
        }
        public static void Test2()
        {
            Console.WriteLine("I AM From Test2 in NewKey class");
        }
        public  static void Main(string[] args)
        {
            NewKey obj = new NewKey();
            Test1();
            Test2();
        }
    }
}
