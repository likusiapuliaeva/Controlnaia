using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tbook[] massTbook = new Tbook[100];
            int a = 0;
            Menu(massTbook, a);
        }
        public struct Tbook
        {
            public string tname { get; set; }
            public string tnomer { get; set; }

            public Tbook(string tname, string tnomer)
            {
                this.tname = tname;
                this.tnomer = tnomer;
            }
        }
        public static void Add(Tbook[] massTbook, int a)
        {
            Console.WriteLine("Введите название контакта");
            string name = Console.ReadLine();
            massTbook[a].tname = name;
            Console.WriteLine("Введите номер телефона");
            string nomer = Console.ReadLine();
            massTbook[a].tnomer = nomer;
            a += 1;
            Console.WriteLine("1 Хотите добавить новую запись");
            Console.WriteLine("2 не хотите добавить новую запись");
            int numd = int.Parse(Console.ReadLine());
            if (numd == 1)
            {
                Add(massTbook, a);
            }
            if (numd == 2)
            {
                Menu(massTbook, a);
            }

        }
        public static void Menu(Tbook[] massTbook, int a)
        {
            do
            {
                Console.WriteLine("   Телефонная книга");
                Console.WriteLine("1.Добавить в телефонную книгу");
                Console.WriteLine("2 Вывод всех записей на экран которые есть на данный момент в адресной книге. ");
                Console.WriteLine("3 Удаление записи по порядковому номеру из списка.");
                Console.WriteLine("5.Выйти");
                Console.WriteLine("Введите цифру");
                int numd = int.Parse(Console.ReadLine());
                if (numd == 1)
                {
                    Add(massTbook, a);

                    Console.WriteLine("операция успешно выполнена");
                }
                else if (numd == 2)
                {
                    Console.WriteLine("|#  |Full Name                 |Phone number");
                    for (int j = 0; j < massTbook.Length - 1; j++)
                    {
                        if (massTbook[j].tname != null)
                        {
                            Console.WriteLine($"|{j + 1}  |{massTbook[j].tname}   |{massTbook[j].tnomer} ");
                        }
                    }
                    Console.WriteLine("операция успешно выполнена");
                }
                else if (numd == 3)
                {
                    Del(massTbook, a);

                    Console.WriteLine("операция успешно выполнена");
                }
                else if (numd == 4)
                {
                    break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static void Del(Tbook[] massTbook, int a)
        {
            Console.WriteLine("Введите название контакта");
            string name1 = Console.ReadLine();
            for (int j = 0; j < massTbook.Length - 1; j++)
            {
                if (massTbook[j].tname == name1)
                {
                    massTbook[j].tname = null;
                    massTbook[j].tnomer = null;
                }
                else if (massTbook[j].tname != name1)
                {
                    Console.WriteLine("Такого пользывателя нет");
                    break;
                }
            }
            Console.WriteLine("1 Хотите Удалить запись");
            Console.WriteLine("2 не хотите удалить запись");
            int numd = int.Parse(Console.ReadLine());
            if (numd == 1)
            {
                Del(massTbook, a);
            }
            if (numd == 2)
                Menu(massTbook, a);
        }
        public static void Oshibka()
        {

        }
    }
}