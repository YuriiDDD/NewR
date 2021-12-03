using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task11_new
{
    class FileSearch
    {

        public static string[] FileSearchByMask (string Path, string Mask)
        {
           
            //Список всех файлов с искомой маской

            string[] Files = null ;

            try
            {
                // Получаем список файлов
                Files = Directory.GetFiles(Path, Mask, SearchOption.AllDirectories);
            }
            catch
            {
                return Files;

            }


            return Files;


        }
        public static void FileSearchByMask(object x)
        {
            Console.WriteLine(Thread.CurrentThread.Name);

            SearchInfoForThread Info = (SearchInfoForThread) x;

            string[] Files = null;

            try
            {
                // Получаем список файлов
                Files = Directory.GetFiles(Info.Path, Info.Mask, SearchOption.AllDirectories);
            }
            catch
            {
                

            }

            PrintFiles(Files);
         


        }



        public static void PrintFiles(string[] Files)
        {
            foreach (string f in Files)
                Console.WriteLine(f);
        
        
        }


    }
}
