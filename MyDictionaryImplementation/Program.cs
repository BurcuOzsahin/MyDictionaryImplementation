using System;
using System.Collections.Generic;

namespace MyDictionaryImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(101, "Calculus");
            myDictionary.Add(201, "Operating System");
            myDictionary.Add(301, "Software Engineering");

            Console.WriteLine("Count: "+myDictionary.Count);
           
            
        }
    }
}
