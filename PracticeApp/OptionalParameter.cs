using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class OptionalParameter
    {
        //Optional parameter should be declared as last parameter it shouldnt be first 
        public void optiopnalPara(int a)
        {
            Console.WriteLine("Hello");
        }
        public void optiopnalPara(int a,int b=0)
        {
            Console.WriteLine("Hello1");
        }
        public void optiopnalPara(int a, int b = 0,string c="")
        {
            Console.WriteLine("Hello1");
        }
    }
}

