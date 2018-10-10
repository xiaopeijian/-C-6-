using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//大写;命名空间、类名、方法名（或函数名）
namespace MyBasicConsoleIO
{
    class GetUserDataClass
    {
        //写在类里面都叫做成员：包括变量、方法（或函数）。
        public void GetUserData()
        {
            Console.WriteLine("请输入你的名字：");
            string userName = Console.ReadLine();//小写：变量（或字段）的首字母小写，其他的首字母大写。
            // public string UserName
            //{
            //    get { return userName; }
            //    set { userName = value;}
            //}
            Console.WriteLine("请输入你的年龄：");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;//控制台前景色
            Console.WriteLine("你好 {0}，你的年龄是{1}岁", userName, userAge);
            //Console.BackgroundColor = ConsoleColor.Black;//控制台前景色
            Console.ForegroundColor = prevColor;//恢复原来的颜色。

            //public string UserName
            //{
            //    get { return userName; }
            //    //set { userName = value};
            //}
    }


        public void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0}", 99999);
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
