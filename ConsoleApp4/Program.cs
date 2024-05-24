using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                string filePath = "C:\\Users\\Student\\Desktop\\1.txt";
                Console.WriteLine("Введите текст для записи в файл:");
                string inputText = Console.ReadLine();
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(inputText);
                }
                Console.WriteLine("Текст успешно записан в файл.");
            }
        }
    }

}
   