﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Handling
{
    public class Example1
    {
        public static void One()
        {
            // Basic Operations
            string fileName = @"C:\Users\rsudha\source\repos\FileHandling\FileHandling\Ratan.txt";
            FileInfo fi = new FileInfo(fileName);
            //using (FileStream fs = fi.Create())
            //{
            //    Byte[] txt = new UTF8Encoding(true).GetBytes("New file.");
            //    fs.Write(txt, 0, txt.Length);
            //    Byte[] author = new UTF8Encoding(true).GetBytes("Author Mahesh Chand");
            //    fs.Write(author, 0, author.Length);
            //}
            string justFileName = fi.Name;
            Console.WriteLine("File Name: {0}", justFileName);
            string fullFileName = fi.FullName;
            Console.WriteLine("File Name: {0}", fullFileName);
            string extn = fi.Extension;
            Console.WriteLine("File Extension: {0}", extn);
            string directoryName = fi.DirectoryName;
            Console.WriteLine("Directory Name: {0}", directoryName);
            bool exists = fi.Exists;
            Console.WriteLine("File Exists: {0}", exists);
            if (fi.Exists)
            {
                long size = fi.Length;
                Console.WriteLine("File Size in Bytes: {0}", size);
                bool IsReadOnly = fi.IsReadOnly;
                Console.WriteLine("Is ReadOnly: {0}", IsReadOnly);
                DateTime creationTime = fi.CreationTime;
                Console.WriteLine("Creation time: {0}", creationTime);
                DateTime accessTime = fi.LastAccessTime;
                Console.WriteLine("Last access time: {0}", accessTime);
                DateTime updatedTime = fi.LastWriteTime;
                Console.WriteLine("Last write time: {0}", updatedTime);
            }
        }

        public static void Two()
        {
            //Creation
            Console.WriteLine("\n Creation of file \n");
            string fileName = @"C:\Users\rsudha\source\repos\FileHandling\FileHandling\Ratan1.txt";
            FileInfo fi = new FileInfo(fileName);
            try
            {
                if (fi.Exists)
                {
                    fi.Delete();
                }
                using(FileStream fs = fi.Create())
                {
                    Byte[] txt = new UTF8Encoding(true).GetBytes("Hello\n");
                    fs.Write(txt, 0, txt.Length);
                    Byte[] author = new UTF8Encoding(true).GetBytes("World");
                    fs.Write(author, 0, author.Length);
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
