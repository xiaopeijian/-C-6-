using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethods
{
    class Program
    {

        ////声明带参数的委托
        //public delegate void MyDelegate(string data);
        ////委托对象
        //static MyDelegate myDelegate;

        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods *****\n");
            Car c1 = new Car("SlugBug", 100, 10);

            int aboutToBlowCounter = 0;

            // Register event handlers as anonymous methods.
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate(object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Message from Car: {0}", e.msg);
            };

            c1.Exploded += delegate(object sender, CarEventArgs e)
            {
                Console.WriteLine("Fatal Message from Car: {0}", e.msg);
            };

            // This will eventually trigger the events.
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine("AboutToBlow event was fired {0} times.", aboutToBlowCounter);




            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //myDelegate = delegate (string data)         //带参数
            //{
            //    Console.WriteLine(data);
            //};
            //myDelegate("带参数的匿名方法");
            //Console.ReadKey();


            //Console.ReadLine();
        }
    }
}
