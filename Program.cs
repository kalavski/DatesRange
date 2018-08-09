using System;
using myapp.Validation;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2 && !Validation.Validation.IsValid(args[0], args[1]))
            {
                return;
            }
            var main = new MainClass();
            Console.WriteLine(main.ShowRange(args[0], args[1]));
        }
    }
}
