
using System;
using System.IO;

namespace FileIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileEx fileEx = new FileEx();

            fileEx.Check();//Check File exist or not 
            Console.WriteLine();

            fileEx.ReadData();// Read All data of file
            Console.WriteLine();

            //fileEx.ReadAllLineEx(); // Read Each Line
            //Console.WriteLine();

            //fileEx.ReadAllBytesEx(); // Read Data in Byte format
            //Console.WriteLine();

            fileEx.WriteData();// Add content in file in string variable formate
            Console.WriteLine();

            fileEx.WriteAllLineEx();// Add content in line in string array fomate
            Console.WriteLine();

            fileEx.AddAtLast(); // add data at last
            
            fileEx.AddLinesAtLast(); // Add new lines ata last
            Console.WriteLine();

           // fileEx.CopyFile();
            Console.WriteLine();

            fileEx.ReadData();
            Console.WriteLine();

            fileEx.DeleteFile();

            Console.ReadLine();
            
        }
    }
}
