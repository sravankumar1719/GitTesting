﻿namespace Testing_Git
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hihi");
            HelloMessage();
            ReplyMessage();
        }

        static void HelloMessage()
        {
            Console.WriteLine("Hello again");
        }

        static void MessageMe()
        {
            Console.WriteLine("I can't message you");
        }

        static void ReplyMessage()
        {
            Console.WriteLine("Hi! How are you?");
        }
    }
}
