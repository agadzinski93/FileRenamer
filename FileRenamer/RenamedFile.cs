using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    internal class RenamedFile
    {
        public ushort Num { get; set; }
        public string NewName { get; set; }
        public string OldName { get; set; }
    }
    internal class RenamedFiles
    {
        public RenamedFiles() { }
        public RenamedFiles(string newDirectory, int numOfFiles) { 
            Directory = newDirectory;
            Files = new RenamedFile[numOfFiles];
        }
        public string Directory { get; set; }
        public RenamedFile[] Files { get; set; }
    }
}
