using System;
using System.IO;

namespace Memory_destroyers
{
    class Program
    {
        // static DriveInfo di = new DriveInfo("c");
        static string drive;
        static long memory;
        static void Main(string[] args)
        {
            Console.WriteLine("What drive do you want to destruct? (For example: if you want to destruct drive D - write D).");
            drive = Console.ReadLine();
            memory = new DriveInfo(drive).TotalFreeSpace / 1000;
            Console.WriteLine("Convirm memory destruction pressing any key");
            Console.ReadKey();
            for (int x = 1; x < memory / 30 + 1; x++)
            {
                if (File.Exists(drive + ":/Memory (" + Convert.ToString(x) + ").txt"))
                {
                    File.Delete(drive + ":/Memory (" + Convert.ToString(x) + ").txt");
                }
                FileStream file = File.Create(drive + ":/Memory (" + Convert.ToString(x) + ").txt");
                file.Close();
                File.AppendAllText(drive + ":/Memory (" + Convert.ToString(x) + ").txt", "S");
                for (var i = 1; i < 31; i++)
                {
                    Console.WriteLine(Convert.ToString(i) + "/30, " + Convert.ToString(x) + "/" + Convert.ToString(memory / 30));
                    File.AppendAllText(drive + ":/Memory (" + Convert.ToString(x) + ").txt", File.ReadAllText(drive + ":/Memory (" + Convert.ToString(x) + ").txt"));
                }
            }
        }
    }
}
