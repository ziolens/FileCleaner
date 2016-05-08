using System;
using System.IO;

namespace FileCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            //brak obsługi wyjątków, co jeśli args[0], args[1], args[2] 
            //to będą niepoprawne dane, lub będzie któregoś brakowało?
            var extensions = ConvertUserArgToExtensions(args[1]);

            string path = args[0];
            string[] files = Directory.GetFiles(path);

            DeleteFiles(files, extensions, args[2]);
        }

        private static void DeleteFiles(string[] files, string[] extensions, string daysArg)
        {
            int days = Int32.Parse(daysArg);
            var cleaner = new Cleaner();
            cleaner.DeleteFiles(files, extensions, days);
        }

        private static string[] ConvertUserArgToExtensions(string arg)
        {
            var extensions = arg.Split(',');
            for (int i = 0; i < extensions.Length; i++)
            {
                extensions[i] = String.Format(".{0}", extensions[i]);
            }
            return extensions;
        }
    }
}
