using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeApp
{
    //Static Keyword
    //Anything marked as a static is basically invoked and controlled by CLR
    //Static can be used with Method / Properties / Class etc..

    #region StaticClass

    public static class MyStaticClass
    {
        public static string Name { get; set; }

        static MyStaticClass()
        {
            Name = "Ankit Sharma";
        }

        //Can't create an instance of the static class
        //CLR will create and keep the instance of the static in the application memory

        //Then how will we access the members of a static class?????

        //All the members of a static class should also be static

        //MemberFunction
        public static void MyFunction()
        {
            //it is mandatory to mark this function as static as the class itself is static.		
        }

    }

    #endregion


    #region StaticMethod

    public class NonStaticClass
    {

        public static void AStaticMethod()
        {

        }


        public static void LogUserActivity(string str)
        {
            Console.WriteLine(str);
        }
    }


    #endregion


    #region StaticVariables

    public class ADifferntNonStaticClass
    {
        public static int Id { get; set; }


        //static ctor
        //static ADifferntNonStaticClass()
        //{
        //	Id = 1000;
        //}

        public ADifferntNonStaticClass()
        {
            Id = 1000;
        }
    }


    #endregion


}
