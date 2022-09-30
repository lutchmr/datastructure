using System;
namespace CommandLineArg
{
    class commandlinearg
    {
        static void MainDemo(string[] args)
        {
            Console.WriteLine($"First Command Line Argument {args[0]}");
            Console.WriteLine($"Second Command Line Argument {args[1]}");
            Console.WriteLine($"Third Command Line Argument {args[2]}");
            Console.ReadLine();
        }
    }
}
