using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleaner myCleaner = new Cleaner();
            string path = args[0];
            byte days = Byte.Parse(args[2]);
            List<string> extensions = new List<string>(args[1].Split(','));
            for (int i = 0; i < extensions.Count; i++)
            {
                extensions[i] = String.Format(".{0}", extensions[i]);
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                myCleaner.deleteFile(file, extensions, days);
            }
        }        
    }
}
