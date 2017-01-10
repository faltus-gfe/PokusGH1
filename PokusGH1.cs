using System;

namespace PokusGH1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Pokus GH 1");

            int len = args.Length;

            Console.WriteLine("- pocet argumentu: {0}", len);
            if (len > 0)
                for (int ii = 0; ii < len; ii++)
                    Console.WriteLine(" -- {0}.parametr = {1}", ii + 1, args[ii]);
        }
    }
}
