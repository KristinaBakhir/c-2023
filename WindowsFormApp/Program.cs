using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography;
using WinFormsApp1;
using System.Windows.Forms;
namespace WinFormsApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Human> listHuman = new List<Human>();
            Adress add1 = new Adress("Spain", "Alicante", "Carrer Castanos", 5);
            Human one = new Human("Jack", "Anderson", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5), "email1");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Human two = new Human("Jack", "Anderson", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5), "email1");
            Human three = new Human("Maison", "Derb", 19, 1.89, 85, true, Nation.French, new Adress("France", "Paris", "loilili", 31), "email2");
            //Human zero = new Human();
            //zero.printInfo();
            listHuman list = new listHuman();
            list.add(one);
            list.add(two);
            list.add(three);
            list.save_txt(list);
            listTeacher listTeacher = new listTeacher();


            Student st_one = new Student("Azamat", "kirbi", 19, 1.88, 80, false, Nation.Polish, new Adress("France", "Paris", "Brovera", 7), "email400", 241, 5000, Key.js);
            Student st_two = new Student("Murad", "kirbi", 19, 1.80, 89, false, Nation.Polish, new Adress("France", "Paris", "Brovera", 7), "email4440", 241, 5000, Key.python);
            Student st_three = new Student("Ahmad", "kirbi", 56, 1.88, 80, true, Nation.Polish, new Adress("France", "Paris", "Brovera", 7), "email4300", 241, 5000, Key.csharp);
            Teacher one_th = new Teacher("Rita", "Jane", 16, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), "email9", 30000, "FKNFM", KeyWords.js, 2);
            one_th.add(st_one);
            one_th.add(st_two);
            one_th.add(st_three);
            one_th.show();
            Teacher two_th = new Teacher("Noah", "Li", 16, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), "email5", 30000, "FKNFM", KeyWords.python, 9);
            listTeacher.add(one_th);
            listTeacher.add(two_th);
            listTeacher.show();
            //listTeacher.save_json();
            //Human.inputInfo(list);
            //list.show();
            /*string choice = null;
            while (choice != "0")
            {
                Console.WriteLine("Выберите действие ");
                Console.WriteLine("0 - выйти с программы.");
                Console.WriteLine("1 - распечатать все объекты");
                Console.WriteLine("2 - найти объект по имени");
                Console.WriteLine("3 - сортировка объектов по возрасту и вывести информацию");
                Console.WriteLine("4 - сортировка объектов по фамилии и вывести информацию");
                Console.WriteLine("5 - создать новый объект и добавить в список");
                Console.WriteLine("6 - изменить значения поля объекта");
                Console.WriteLine("7 - удалить объект");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("До свидания!");
                        break;
                    case "1":
                        list.show();
                        break;
                    case "2":
                        Console.WriteLine("Введите имя ");
                        string name = Console.ReadLine();
                        list.findName(name);
                        break;
                    case "3":
                        list.sort_age();
                        break;
                    case "4":
                        list.sort_surname();
                        break;
                    case "5":
                        Human.inputInfo(list);
                        Console.WriteLine("Теперь наш список выглядит так: ");
                        list.show();
                        break;
                    case "6":
                        string c = null;
                        while (c != "0")
                        {
                            Console.WriteLine("Выберите действие ");
                            Console.WriteLine("0 - вернуться в главное меню.");
                            Console.WriteLine("1 - изменить имя");
                            Console.WriteLine("2 - изменить фамилию");
                            Console.WriteLine("3 - изменить возраст");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.WriteLine("Введите имя объекта которое хотите изменить: ");
                                    string firstName = Console.ReadLine();
                                    Console.WriteLine("Введите имя на которое хотите изменить: ");
                                    string secondName = Console.ReadLine();
                                    list.find_change_name(firstName, secondName);
                                    break;
                                case "2":
                                    Console.WriteLine("Введите фамилию объекта которую хотите изменить: ");
                                    string firstSurname = Console.ReadLine();
                                    Console.WriteLine("Введите фамилию на которую хотите изменить: ");
                                    string secondSurname = Console.ReadLine();
                                    list.find_change_surname(firstSurname, secondSurname);
                                    break;
                                case "3":
                                    Console.WriteLine("Введите имя объекта чей возраст вы хотите изменить: ");
                                    string Name = Console.ReadLine();
                                    Console.WriteLine("Введите фамилию объекта чей возраст вы хотите изменить: ");
                                    string SurName = Console.ReadLine();
                                    Console.WriteLine("Введите возраст на который хотите изменить: ");
                                    int Age = int.Parse(Console.ReadLine());
                                    list.find_change_age(Name, SurName, Age);
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели неверный номер!");
                                    break;
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введите имя объекта который хотите удалить: ");
                        string name_human = Console.ReadLine();
                        Console.WriteLine("Введите фамилию объекта который хотите удалить: ");
                        string surName = Console.ReadLine();
                        list.remove(name_human, surName);
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный номер!");
                        break;

                }
            }*/
            Console.ReadLine();
        }
    }
}