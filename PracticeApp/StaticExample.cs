using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    static class StaticExample
    {
        static int a ;

        public static void demo()
        {
            Console.WriteLine("Static Method");
            a = 20;
            Console.WriteLine(a);
        }
        static StaticExample()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    public class NonStatic
    {
        public static int b=20 ;

        public static void demotwo()
        {
            Console.WriteLine("Static Method");
           
        }
        static NonStatic()
        {
            Console.WriteLine("Static Constructor");
        }
        public void Demotwoo()
        {
            b = 30;
            Console.WriteLine(b);
        }
    }
}
