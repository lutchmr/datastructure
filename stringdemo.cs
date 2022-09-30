using System;
namespace DataTypesString
{
    class datatypestring
    {
        static void MainDemo(string[] args)
        {
            string str = "Hello World";
            var bytecount = str.Length * sizeof(Char);
            Console.WriteLine($"str Value: {str}");
            Console.WriteLine($"str Size: {bytecount}");
            Console.ReadKey();
        }
    }
}