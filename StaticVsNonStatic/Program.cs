using System;

namespace StaticVsNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //static constructor in a static class runs only once when any of its static members accessed for the first time
            MyStaticClass.myStaticVariable = 100;
            MyStaticClass.MyStaticProperty = 200;
            MyStaticClass.myStaticVariable = 300;
            MyStaticClass.MyStaticProperty = 400;

            //static constructor in a non-static class runs only once when the class is instantiated for the first time
            MyNonStaticClass mnsObj1 = new MyNonStaticClass();
            MyNonStaticClass mnsObj2 = new MyNonStaticClass();
            MyNonStaticClass mnsObj3 = new MyNonStaticClass();
            Console.WriteLine(mnsObj1.add(1, 1));
        }
    }
}
