using System;
using System.IO;

namespace Memory_destroyers
{
    class Program
    {
        // static DriveInfo di = new DriveInfo("c");
        static string drive;
        static int memory;
        static void Main(string[] args)
        {
            Console.WriteLine("What drive do you want to destruct? (For example: if you want to destruct drive D - write D).");
            drive = Console.ReadLine();
            // memory = new DriveInfo(drive).TotalFreeSpace / 1000;
	    Console.WriteLine("How many GibiBytes do you want to waste?")
	    memory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Convirm memory destruction pressing any key");
            Console.ReadKey();
            for (int x = 0; x < memory; x++)
            {
                if (File.Exists(drive + "/Memory (" + Convert.ToString(x) + ").txt"))
                {
                    File.Delete(drive + "/Memory (" + Convert.ToString(x) + ").txt");
                }
                FileStream file = File.Create(drive + "/Memory (" + Convert.ToString(x) + ").txt");
                file.Close();
		for (int i = 0; i < 1024; i++)
		{	
			Console.WriteLine(x + " GiB " + i + " MiB " + "[" + new string('#', Convert.ToInt16(Convert.ToDouble(x * 1024 + i) / (memory * 1024) * 100)) + new string ('.', Convert.ToInt16(100 - Convert.ToDouble(x * 1024 + i) / (memory * 1024) * 100)) + "] " + (Convert.ToInt16(Convert.ToDouble(x * 1024 + i) / (memory * 1024) * 100)) + "%");
			File.AppendAllText(drive + "/Memory (" + Convert.ToString(x) + ").txt", new string('S', 1024 * 1024));
		}
            }
        }
    }
}
