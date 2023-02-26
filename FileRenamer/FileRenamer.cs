using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using static FileRenamer.RenamedFile;
using System.Net.Http.Headers;

namespace FileRenamer
{
    internal abstract class FileRenamer
    {
        /**
         * <summary>
         * Returns whether the input string contains valid characters for the Windows File System
         * </summary>
         **/
        public static bool ValidateNewString(string input)
        {
            bool valid = true;
            char[] excludedChars = new char[] { '/', '\\', '*', ':', '?', '"', '<', '>', '|' };
            if (input.IndexOfAny(excludedChars) != -1)
            {
                valid = false;
            }
            return valid;
        }
        /**
         * <summary>
         * Sets the first and last file to rename, returns -1 if an error occurs
         * string txtStart - 1-based index of first file to rename
         * string txtEnd - 1-based index of last file to rename
         * Tuple<int,int> - 0-based indexes of first and last file to rename
         * </summary>
         **/
        public static Tuple<int, int> SetRangeOfFilesToRename(string txtStart,string txtEnd, int numOfFiles) {
            int firstFileToRename = 0;
            int lastFileToRename = 0;

            firstFileToRename = (txtStart != ""
                    && Int32.Parse(txtStart) > 0
                    && Int32.Parse(txtStart) <= numOfFiles) ? Int32.Parse(txtStart) - 1 : 0;
            lastFileToRename = (txtEnd != ""
                && Int32.Parse(txtEnd) != 0
                && Int32.Parse(txtEnd) <= numOfFiles) ? Int32.Parse(txtEnd) : numOfFiles;
            if (firstFileToRename > lastFileToRename)
            {
                firstFileToRename = -1;
            }
            return Tuple.Create(firstFileToRename, lastFileToRename);
        }
        public static int SetStartPosition(string input)
        {
            int pos = 0;
            pos = Int32.Parse(input) - 1;
            return pos;
        }
        public static string[,] RenameFiles(string newText, Tuple<int, int> range, FileInfo[] files, int startPos, int numOfCharsToReplace)
        {
            string[,] names = new string[2,range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                replace = file.Name.Replace(file.Name.Substring(startPos, numOfCharsToReplace), newText);
                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static string[,] RenameFilesWithIncrement(string newText, Tuple<int, int> range, FileInfo[] files, int startPos, int numOfCharsToReplace,
            ushort incrementLength, bool incrementLengthValid, ushort incrementStart, byte incrementStep)
        {
            string[,] names = new string[2, range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                if (incrementLengthValid)
                {
                    replace = file.Name.Replace(file.Name.Substring(startPos, numOfCharsToReplace), newText + (incrementStart).ToString("D" + incrementLength.ToString()));
                }
                else
                {
                    replace = file.Name.Replace(file.Name.Substring(startPos, numOfCharsToReplace), newText + (incrementStart).ToString());
                }

                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                incrementStart += incrementStep;
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static string[,] RenameFilesAtStart(string newText, Tuple<int,int> range, FileInfo[] files) {
            string[,] names = new string[2, range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                replace = file.Name.Insert(0, newText);
                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static string[,] RenameFilesAtStartWithIncrement(string newText, Tuple<int, int> range, FileInfo[] files,
            ushort incrementLength, bool incrementLengthValid, ushort incrementStart, byte incrementStep)
        {
            string[,] names = new string[2, range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                if (incrementLengthValid)
                {
                    replace = file.Name.Insert(0, newText + (incrementStart).ToString("D" + incrementLength.ToString()));
                }
                else
                {
                    replace = file.Name.Insert(0, newText + (incrementStart).ToString());
                }

                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                incrementStart += incrementStep;
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static string[,] RenameFilesAtEnd(string newText, Tuple<int, int> range, FileInfo[] files)
        {
            string[,] names = new string[2, range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                replace = file.Name.Insert(file.Name.Length, newText);
                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static string[,] RenameFilesAtEndWithIncrement(string newText, Tuple<int,int> range, FileInfo[] files, 
            ushort incrementLength, bool incrementLengthValid, ushort incrementStart, byte incrementStep)
        {
            string[,] names = new string[2, range.Item2 - range.Item1];
            string replace;
            for (int i = range.Item1; i < range.Item2; i++)
            {
                FileInfo file = files[i];
                if (incrementLengthValid)
                {
                    replace = file.Name.Insert(file.Name.Length, newText + (incrementStart).ToString("D" + incrementLength.ToString()));
                }
                else
                {
                    replace = file.Name.Insert(file.Name.Length, newText + (incrementStart).ToString());
                }

                File.Move(file.FullName, file.FullName.Replace(file.Name, replace));
                incrementStart += incrementStep;
                names[0, i] = file.Name;
                names[1, i] = replace;
            }
            return names;
        }
        public static void WriteBackupforRenamedFiles(string directory, string[,] names)
        {
            string filename = "renamedBackup.json";
            int length = names.GetLength(1);
            RenamedFiles rfs = new RenamedFiles(directory, length);
            RenamedFile rf;
            for (ushort i = 0; i < length; i++)
            {
                rf = new RenamedFile
                {
                    Num = (ushort)(i + 1),
                    OldName = names[0,i],
                    NewName = names[1,i]
                };
                rfs.Files[i] = rf;
            }
            string json = JsonSerializer.Serialize(rfs);
            File.WriteAllText(filename,json);
        }
        public static void UndoRenamedFiles(RenamedFiles fileNames) {
            //Gather the files in the directory
            DirectoryInfo di = new DirectoryInfo(fileNames.Directory);
            FileInfo[] files = di.GetFiles();

            int length = fileNames.Files.Length;
            ushort j = 0;
            bool done = false;
            string replace;
            for (int i = 0; i < length; i++)
            {
                j = 0;
                done = false;
                while(!done && j < files.Length) { 
                    if (fileNames.Files[i].NewName == files[j].Name)
                    {
                        replace = di.FullName.Insert(di.FullName.Length, "\\" + fileNames.Files[i].OldName);
                        File.Move(files[j].FullName, replace);
                        done = true;
                    }
                    j++;
                }
            }
        }
    }
}
