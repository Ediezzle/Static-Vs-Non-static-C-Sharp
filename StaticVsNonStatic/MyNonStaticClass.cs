using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsNonStatic
{
    //constructor cannot have an access modifier if it's static
    class MyNonStaticClass
    {
        static int myStaticInt = 0;
        static int i = 1;
        double age = 21;
        //static constructor in a non-static class runs only once when the class is instantiated for the first time
        public MyNonStaticClass()
        {
            myStaticInt++;
            Console.WriteLine("Inside non-static constructor.");
        }

        static MyNonStaticClass()
        {
            myStaticInt++;
            Console.WriteLine("Inside static constructor.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }

        //non-static methods can access static class variables since they belong to the whole class
        public int add(int a, int b)
        {
            Console.WriteLine("myStaticInt variable now " + myStaticInt);
            return a + b + i;
        }

        //Static methods cannot access class members since they belong to an instance of the class
        /*public static void setAge(double zera)
        {
            this.age = zera;
        } */
    }
}
