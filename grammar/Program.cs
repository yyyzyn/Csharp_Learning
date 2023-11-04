// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big GiveWay");
            Console.Write("Choose a door:1,2 or 3");

            /*
            string userValue = Console.ReadLine();
            
            if(userValue=="1")//if判断语句，"=="判断真伪  
            {
                string message = "You win a new switch";
                Console.WriteLine(message);
            }
            else if(userValue=="2")//else if 判断语句
            {
                string message = "You win a new XBOX";
                Console.WriteLine(message);
            }
            else if(userValue=="3")
            {
                string message = "You win a new PS5";
                Console.WriteLine(message);
            }

            else
            {
                string message = "Sorry";
                Console.WriteLine(message);
            }

            Console.ReadLine();
            */

            //第二种写法
            string userValue = Console.ReadLine();
            string message = "";


            if (userValue == "1")//if判断语句，"=="判断真伪  
            {
                message = "You win a new switch";
            }
            else if (userValue == "2")//else if 判断语句
            {
                 message = "You win a new XBOX";
            }
            else if (userValue == "3")
            {
                 message = "You win a new PS5";
            }

            else
            {
                 message = "Sorry";
                //message = message + "You loss.";
                 message += "You Lose.";//等于message = message + "You loss.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}


//列表中第一个元素永远是0，第二个元素才是1