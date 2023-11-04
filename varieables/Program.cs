// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Exercise2  
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;//定义变量
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);//输出变量y
            Console.WriteLine(x);//输出变量x
            Console.ReadLine();  
            */


            Console.WriteLine("What is your name?");//显示里面内容
            Console.Write("Type your first name");//写出你的姓名，才能前往下一步
            string myFirstName;//字符串数据类型

            myFirstName = Console.ReadLine();//读取输入，暂存

            /*
            string myLastName;//字符串数据类型
            Console.Write("Type your last name");
            myLastName = Console.ReadLine();//读取输入，暂存
            */


            //第二种写法
            Console.WriteLine("Type your last name");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello,"+myFirstName+" "+myLastName);
            Console.ReadLine();

        }
    }
}