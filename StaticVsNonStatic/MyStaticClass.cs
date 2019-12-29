using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsNonStatic
{
    static class MyStaticClass
    {
        public static int myStaticVariable = 0;
        //cannot have access modifier by virtue of being static
        //static constructor in a static class runs only once when any of its static members accessed for the first time
        static MyStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }

        public static void myStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public static int MyStaticProperty { get; set; }

    }
}
