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
            Menu(massTbook,a);
            
        }
        public struct Tbook
        {
            public string tname { get; set; }
            public int tnomer { get; set; }

            public Tbook(string tname, int tnomer)
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
            AddTel(massTbook, a);
           
        }
        public static void AddTel(Tbook[] massTbook, int a)
        {
            int number;
            Console.WriteLine("Введите номер телефона 0xxxxxxxx ");
            string numb = Console.ReadLine();

            bool result = int.TryParse(numb, out number);
            if (result == false)
            {
                Console.WriteLine("ошибка, неверный ввод нмера телефонна");
                AddTel(massTbook, a);
            }
             else if (result == true)
            {
                int numd = int.Parse(numb);
                if (numd > 100000000 && numd < 999999999)
                {

                    massTbook[a].tnomer = numd;
                    a += 1;
                    OshibkaAdd(massTbook, a);
                }
                else
                {
                    Console.WriteLine("ошибка,неправельный номер телефон");
                    AddTel(massTbook, a);
                }
            }
        }     
        public static void OshibkaAdd(Tbook[] massTbook, int a)
        {
            int number;
            Console.WriteLine("операция успешно выполнена");
            Console.WriteLine("1 Хотите добавить новую запись");
            Console.WriteLine("2 не хотите добавить новую запись");
            Console.WriteLine("Введите цифру");
            string numb = Console.ReadLine();

            bool result = int.TryParse(numb, out number);
            if (result == false)
            {
                Console.WriteLine("ошибка, введите число от  1 до 2");
                Menu(massTbook, a);
            }

            if (result == true)
            {
                int numd = int.Parse(numb);

                if (numd == 1)
                {
                    Add(massTbook, a);
                }
                else if (numd == 2)
                {
                    Menu(massTbook, a);
                }
                else
                {
                    Console.WriteLine("ошибка, Введите число от  1 до 2");
                    OshibkaAdd(massTbook, a);
                }
            }
        }

        public static void Menu(Tbook[] massTbook,int a)
        {
            do
            {
                Console.WriteLine("   Телефонная книга");
                Console.WriteLine("1.Добавить в телефонную книгу");
                Console.WriteLine("2 Вывод всех записей на экран которые есть на данный момент в адресной книге. ");
                Console.WriteLine("3 Удаление записи по порядковому номеру из списка.");
                Console.WriteLine("4.Выйти");
               
                   int number;
                   Console.WriteLine("Введите цифру");
                   string numb = Console.ReadLine();

               bool result = int.TryParse(numb, out number);
                if (result == false)
                {
                    Console.WriteLine("ошибка, Введите число от  1 до 4");
                    Menu(massTbook, a);
                }
            
                if (result == true)
                {
                   int numd = int.Parse(numb);
                    if (numd == 1)
                    {
                        Add(massTbook, a);

                    }
                    else if (numd == 2)
                    {
                        Console.WriteLine("|#  |Full Name                 |Phone number");
                        for (int j = 0; j < massTbook.Length; j++)
                        {
                            if (massTbook[j].tname != null)
                            {
                                Console.WriteLine($"|{j + 1}  |{massTbook[j].tname}   |0{massTbook[j].tnomer} ");
                            }
                        }

                        Console.WriteLine("операция успешно выполнена");
                        Menu(massTbook, a);
                    }
                    else if (numd == 3)
                    {
                        Del(massTbook, a);
                        
                    }
                    else if (numd == 4)
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {

                        Console.WriteLine("ошибка, Введите число от  1 до 4");
                        Menu(massTbook, a);

                    }
                  }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static void Del(Tbook[] massTbook, int a)
        {
            Console.WriteLine("Введите название контакта");
            string name1 = Console.ReadLine();
            
                        
                for (int j = 0; j < 100; j++)
                {
                if (massTbook[j].tname == name1)
                {
                    massTbook[j].tname = null;
                    massTbook[j].tnomer = 0;
                    Console.WriteLine("операция успешно выполнена");
                    break;
                }
                else if (j == 99 && massTbook[99].tname!= name1)
                      {
                        Console.WriteLine("Такого пользывателя нет");
                     }
            }
          
            OshibkaDel(massTbook, a);

        }
        public static void OshibkaDel(Tbook[] massTbook, int a)
        {
            int number;
            Console.WriteLine("1 Хотите ещё удалить запись");
            Console.WriteLine("2 не хотите удалить запись");
            Console.WriteLine("Введите цифру");
            string numb = Console.ReadLine();

            bool result = int.TryParse(numb, out number);
            if (result == false)
            {
                Console.WriteLine("ошибка, Введите число от  1 до 2");
                Menu(massTbook, a);
            }

            if (result == true)
            {
                int numd = int.Parse(numb);

                if (numd == 1)
                {
                    Del(massTbook, a);
                }
                else if (numd == 2)
                {
                    Menu(massTbook, a);
                }
                else
                {
                    Console.WriteLine("ошибка, Введите число от  1 до 2");
                    OshibkaDel(massTbook, a);
                }
            }
        }

     }
}
