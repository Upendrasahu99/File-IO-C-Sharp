using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileIo
{
    internal class FileEx
    {
        string path = @"D:\CS\C#.NET\code\\1FileForPractice\Sample1.txt";
        public void Check() // Check file is exist or not
        {
            Console.WriteLine(File.Exists(path));
        }

        public void ReadData() // Read data from file 
        {
            Console.WriteLine(File.ReadAllText(path));
        }

        public void ReadAllLineEx() 
        {
            string[] testDatLineByLine = File.ReadAllLines(path); // store every line in new index of an array
            foreach (var item in testDatLineByLine)
            {
                Console.WriteLine(item); // write all line
            }
            Console.WriteLine(testDatLineByLine[2]); // check index 2 or line number 3
        }

        public void ReadAllBytesEx()  
        {
            byte[] byteData = File.ReadAllBytes(path); // read data as binary data
            foreach (var item in byteData)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteData()
        {
            string data = "writing Data using C# Code";
            File.WriteAllText(path, data); // write the contents of string vaiable in the file and also change the value
        }

        public void WriteAllLineEx()
        {
            string[] data = { "aaa", "bbb", "ccc", "ddd" };
            File.WriteAllLines(path, data); // write the contenst in string array format where every index is new line and also change the value

        }

        public void AddAtLast()
        {
            string data = "Add data at last of file";
            File.AppendAllText(path, data); // Add data at last of file in string variable format.
        }

        public void AddLinesAtLast()
        {
            string[] data = { "Last1", "Last2", "Last3" };
            File.AppendAllLines(path, data); //Add new lines in the file in array of string format.
        }

        public void CopyFile()
        {
            string secondFilePath = @"D:\CS\C#.NET\code\\1FileForPractice\Sample2.txt";
            File.Copy(path, secondFilePath, true);
            Console.WriteLine(File.ReadAllText(secondFilePath));
        }

        public void DeleteFile()
        {
            string thirdFilepath = @"D:\CS\C#.NET\code\\1FileForPractice\Sample3.txt";
            File.Delete(thirdFilepath);
        }
    }
}
