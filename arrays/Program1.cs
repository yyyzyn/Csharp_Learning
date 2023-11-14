// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace arrays
{
    class Program1
    {
        static void Main()
        {
            //字符串学习2
            //字符串反转

            string zig = "you can get your life that you want to become a person"+"if you will become strong";

            char[] charArray = zig.ToCharArray();//帮助器
            Array.Reverse(charArray);

            foreach(char zigChar in charArray )
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();


        }
    }
}
