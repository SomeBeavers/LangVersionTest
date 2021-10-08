// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
// 6
using static System.Console;

class MyClass
{
    public static void Main2()
    {
        WriteLine("Hello, World!");

        // 7.0
        void LocalFunction()
        {
        }

        // 8
        using var file = new System.IO.StreamWriter("WriteLines2.txt");

        // 9
        List<string> l = new();

        //// 10
        //const string s2 = "VALUE";
        //const string s1 = $"{s2}";
    }
}
