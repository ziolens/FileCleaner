using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileCleaner
{
    public class Cleaner
    {
        private void DeleteFile(string fileName, IEnumerable<string> extensions, int days)
        {
            var fileInfo = new FileInfo(fileName);
            int daysToSubstract = days * -1;
            if (extensions.Contains(fileInfo.Extension) 
                && fileInfo.LastWriteTime < DateTime.Today.AddDays(daysToSubstract))
            {
                fileInfo.Delete();
            }
        }

        public void DeleteFiles(string[] files, string[] extensions, int days)
        {
            foreach (string file in files)
            {
                DeleteFile(file, extensions, days);
            }
        }
    }
}
