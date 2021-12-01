using System;
using System.IO;

namespace Task_6_3
{
    class Program
    {
        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                // Имитируем удаление
                Console.WriteLine("Delete:" + path);
                // Настоящее удаление
                ///   File.Delete(files[i]);
            }
        }
        
        static void Main(string[] args)
        {
            string[] points = { "1) Удалить выбранное", "2) Снять отметки", "3) Выделить все", "4) Выход" };
            Console.OutputEncoding = System.Text.Encoding.UTF8;

        //    Console.WriteLine("Введите путь:");
            //var path = Console.ReadLine(); 
            var path = @"C:\Users\3213897\OneDrive - Jabil\Documents";
      //      Console.WriteLine("Введите искомую маску:");
            //var mask = Console.ReadLine();
            var mask = "*.txt";
         
            //Список всех файлов с искомой маской
            string[] files = Directory.GetFiles(path, mask, SearchOption.AllDirectories);
            //Поиск файлов удовлетворяющих маске и диапазону дат и запись в лог файл
            for (int i = 0; files.Length > i; i++)
            {
                Console.WriteLine("{0} {1}",i, files[i]);
            }
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1) Удалить все 2) Удалить определенный файл 3) Удалить диапазон файлов 4) Выход");
            int ?y = -1;
            while (y!=4)
            {
                y = Convert.ToInt32(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        for (int i = 0; files.Length > i; i++)
                        {
                            DeleteFile(files[i]);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Выберите номер файла для удаления:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        DeleteFile(files[n]);
                        break;
                    case 3:
                        Console.WriteLine("Выберите диапазон файлов для удаления: начало конец");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());

                        for (int i = a; b>= i; i++)
                        {
                            DeleteFile(files[i]);
                        }
                        break;

                    case 4: 
                        break;
                }

            }



           
        }
    }
}
