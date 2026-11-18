using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.ex2.p10.v2
{
    internal class Class1
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string fileName = @"C:\New folder\test.txt";
            string xLine = "";

            FileStream fstr = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fstr);

            Console.WriteLine("Въведи редове във файла: ");
            string input = Console.ReadLine();
            for(;input != "";)
            {
                streamWriter.WriteLine(input);
                input = Console.ReadLine();
            }
            streamWriter.Flush();
            streamWriter.Close();


            Console.WriteLine("----ЧЕТЕНЕ НА ФАЙЛА------------------------");
            Console.WriteLine("-----чрез StreamReader---------------------");

            fstr = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader streamRd = new StreamReader(fstr);

            for(;xLine != null;)
            {
                xLine = streamRd.ReadLine();
                Console.WriteLine(xLine);
            }
            Console.ReadKey();
        }
    }
}
