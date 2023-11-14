// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Reflection.Metadata;

namespace understandingarrays
{
    class Program
    {
        static void Main(string[] strings)
        /*
    {
        //数组的学习与使用
        int[] numbers = new int[5];//方括号在基类型后，不在变量名后面，与C/C++不一样
        numbers[0] = 4;
        numbers[1] = 8;
        numbers[2] = 15;
        numbers[3] = 16;
        numbers[4] = 23;

        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers.Length);//输出数组的长度
        Console.ReadLine();
    }
        */


        //int[] numbers = new int[] { 4,8,15,16,23,42 };//另一种表达方式

        //字符串数组使用
        //第一种输出方法
        {
            string[] names = new string[] { "Eddie", "Alex", "Michael", "EDA" };//定义字符串数组

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }
            Console.ReadLine();

            string[] numbers = new string[] { "zhang", "sha", "wang", "bei" };//定义字符串数组2

            //第二种输出办法

            foreach(string number in numbers)
            {
                Console.WriteLine(number);//与python里面方法很相似
            }

            Console.ReadLine();

        }

    }

 }


