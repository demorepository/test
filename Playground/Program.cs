using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            foreach ( var item in class1.arrayTest)
                {
                Console.WriteLine(item);

                }

            Class2 class2 = new Class2();
            class2.findById(1);


            Console.ReadKey();
        }

        
        
        
    }
}
