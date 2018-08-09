using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new MainClass();
            if(args.Length == 2)
            {
                Console.WriteLine(main.ShowRange(args[0], args[1]));
            }
        }
    }
}
