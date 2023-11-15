// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace SimpleMethod
{
    class Program1
    {
        static void Main()
        {
            HelloWorld();//调用方法
            Console.ReadLine();
        }


        private static void HelloWorld()//定义方法
        {
            Console.WriteLine("Hello world!");
        }
    }
}
