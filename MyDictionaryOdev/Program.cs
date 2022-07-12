using System;

namespace MyDictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryOdev<string> myDictionaryOdev = new MyDictionaryOdev<string>();
            myDictionaryOdev.Add("Nermin");
            myDictionaryOdev.Add("SpiderMan");
            myDictionaryOdev.Add("Batman");
            Console.WriteLine(myDictionaryOdev.Count);
        }
    }
}
