using System;
using myapp2.Validation;

namespace myapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2 && !Validation.Validation.IsValid(args[0], args[1]))
            {
                return;
            }
            var main = new DateRange();
            Console.WriteLine(main.ShowRange(args[0], args[1]));
        }
    }
}
