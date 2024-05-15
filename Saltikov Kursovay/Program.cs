using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saltikov_Kursovay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Pilot\Desktop\Saltikov Kursovay\File.txt";
            DoublyLinkedList library = new DoublyLinkedList();
            library.LoadFromFile(filePath);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\tМеню:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Добавить книгу в начало списка");
                Console.WriteLine("2. Добавить книгу в конец списка");
                Console.WriteLine("3. Добавить книгу в позицию, отсортированную по имени в алфавитном порядке");
                Console.WriteLine("4. Добавление книги после определенной книги");
                Console.WriteLine("5. Добавление книги перед определенной книги");
                Console.WriteLine("6. Удаление данных о списываемых книгах");
                Console.WriteLine("7. Вывести сведения о налмичии книг в библиотеке, упорядоченные по годам издания");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("8. Выход");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Выберите действие: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректные данные!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Добавить книгу в начало списка:");
                        pattern.OutPut();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Добавить книгу в конец списка:");
                        pattern.Start();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Добавить книгу в позицию, отсортированную по имени в алфавитном порядке:");
                        pattern.End();
                        Console.WriteLine("Чтобы потвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Добавление книги после определенной книги:");
                        pattern.Middle();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Добавление книги перед определенной книги:");
                        pattern.Before();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Удаление данных о списываемых книгах:");
                        pattern.Dellete();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Вывести сведения о наличии книг в библиотеке, упорядоченные по годам издания:");
                        pattern.SearchKorpus();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;

                    case 8:
                        library.SaveToFile(filePath);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Программа завершена.");
                        return;



                }
            }
        }
    }
}
