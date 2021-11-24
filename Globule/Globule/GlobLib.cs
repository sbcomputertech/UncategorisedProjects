using System;
using System.Text;

namespace Globule
{
    static class GlobLib
    {
        public static string LoadGlob (string path)
        {
            int lineID = 0;
            string[] lines = System.IO.File.ReadAllLines(path);
            string returnValue = "";
            foreach (string line in lines)
            {
                lineID++;
                if (lineID == 1 && line != "|glob<>file|")
                    Console.WriteLine("ERROR:Globfile.Header¦Incorrect");
                else if (lineID == 1)
                {
                    continue;
                }
                else
                {
                    returnValue = returnValue + line + "\n";
                }
            }
            return returnValue;
        }
        public static void AddToGlob(string path, string data)
        {
            string prevGlob = System.IO.File.ReadAllText(path);
            string newGlob = prevGlob + data;
            System.IO.File.WriteAllText(path, newGlob);
        }
        public static string OverwriteGlob(string path, string data, bool confirm)
        {
            if (confirm)
            {
                string backup = System.IO.File.ReadAllText(path);
                System.IO.File.WriteAllText(path, data + "\n");
                return backup;
            }
            else
            {
                return "ERROR:Globfile.Overwrite¦Unconfirmed";
            }
        }
        public static string ToGlobule(string srcPath, string destPath)
        {
            string originalData = System.IO.File.ReadAllText(srcPath);
            string writeData = "|glob<>file|\n" + originalData;
            System.IO.File.WriteAllText(destPath, writeData);
            return writeData;
        }
    }
}
