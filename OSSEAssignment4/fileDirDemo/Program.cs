using System;
using System.IO;

namespace fileDirDemo
{
    class Program
    {
        static void Mainw(string[] args)
        {
                        //Directory Demo
            string rootPath = @"C:\myfirstreact\public\NewDirectory";

            //  string[] dirs = Directory.GetDirectories(rootPath);

            // string[] dirs = Directory.GetDirectories(rootPath, "*",SearchOption.AllDirectories);
            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}


            //Files Demo


            //var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //  //  Console.WriteLine(file);
            //    //  Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    // Console.WriteLine(Path.GetFullPath(file));
            //    //   Console.WriteLine(Path.GetDirectoryName(file));

            //        var info = new FileInfo(file);
            //   //  Console.WriteLine(info.Length);
            //        Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");
            //    }

            //Exits

            //    bool directoryExists = Directory.Exists(@"C:\myfirstreact\public\NewDirectory\Folder1\SubFolde1a");

            //if (directoryExists)
            //{
            //    Console.WriteLine("The Directory exists");

            //}
            //else
            //{
            //    Console.WriteLine("The directory doesn't exist");
            //}

            // Copying files 

            string[] files = Directory.GetFiles(rootPath);
            string destiationFolder = @"C:\myfirstreact\public\NewDirectory\Folder1\SubFolde1A\";

            foreach (string file in files)
            {
                File.Copy(file, $"{ destiationFolder}{ Path.GetFileName(file)}", true);
            }

            //Moving files
            //Console.ReadLine();
        }
        }
}
