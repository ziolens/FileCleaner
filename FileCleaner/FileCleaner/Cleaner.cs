using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCleaner
{
    class Cleaner
    {
        public void deleteFile(string fileToDelete, List<string> extensions, byte days)
        {
            FileInfo fileInfo = new FileInfo(fileToDelete);
            if (extensions.Contains(fileInfo.Extension) && fileInfo.LastWriteTime < DateTime.Today.AddDays(days * -1))
            {
                fileInfo.Delete();
            }
        }        
    }
}
