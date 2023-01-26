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
            List<Human> listHuman=new List<Human>();
            Adress add1=new Adress("Ukraine", "Kherson", "Polyova", 58);
            Human one=new Human("Alex", "Anderson", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5), "email1");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Human two=new Human("Alex", "Anderson", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5), "email1");
            Human three=new Human("Berbek", "Karlson", 19, 1.91, 90, true, Nation.French, new Adress("France", "Paris", "loilili", 31), "email2");
            //Human zero = new Human();
            //zero.printInfo();
            listHuman list=new listHuman();
            list.add(one);
            list.add(two);
            list.add(three);
            list.save_txt(list);
            listTeacher listTeacher=new listTeacher();


            Student st_one=new Student("Ruslan", "Polyak", 20, 1.78, 70, false, Nation.Polish, new Adress("France", "Paris", "Torna", 6), "email400", 241, 5000, Key.js);
            Student st_two=new Student("Victor", "Abramov", 19, 1.80, 89, false, Nation.Polish, new Adress("France", "Paris", "Torna", 6), "email4440", 241, 5000, Key.python);
            Student st_three=new Student("David", "Marham", 56, 1.88, 80, true, Nation.Polish, new Adress("France", "Paris", "Torna", 6), "email4300", 241, 5000, Key.csharp);
            Teacher one_th=new Teacher("Alina", "Car", 17, 1.63, 55, false, Nation.French, new Adress("France", "Paris", "Torna", 6), "email9", 30000, "FKNFM", KeyWords.js, 2);
            one_th.add(st_one);
            one_th.add(st_two);
            one_th.add(st_three);
            one_th.show();
            Teacher two_th=new Teacher("Jackel", "Ball", 17, 1.85, 70, false, Nation.French, new Adress("France", "Paris", "Torna", 6), "email5", 30000, "FKNFM", KeyWords.python, 9);
            listTeacher.add(one_th);
            listTeacher.add(two_th);
            listTeacher.show();
            //listTeacher.save_json();
            //Human.inputInfo(list);
            //list.show();
            /*string choice=null;
            while (choice!="0")
            {
                Console.WriteLine("Выберите действие ");
                Console.WriteLine("0 - вийти з програми.");
                Console.WriteLine("1 - надрукувати всі об'єкти");
                Console.WriteLine("2 - знайти об'єкт за ім'ям");
                Console.WriteLine("3 - сортування об'єктів за віком та вивести інформацію");
                Console.WriteLine("4 - сортування об'єктів за призвіщем та вивести нформацію");
                Console.WriteLine("5 - створити новий об'єкт та додати в список");
                Console.WriteLine("6 - змінити значення поля об'єкту");
                Console.WriteLine("7 - видалити об'єкт");
                choice=Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Допобачення!");
                        break;
                    case "1":
                        list.show();
                        break;
                    case "2":
                        Console.WriteLine("Введіть ім'я ");
                        string name=Console.ReadLine();
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
                        Console.WriteLine("Тепер наш список виглядає так: ");
                        list.show();
                        break;
                    case "6":
                        string c=null;
                        while (c!="0")
                        {
                            Console.WriteLine("Оберіть дію ");
                            Console.WriteLine("0 - повернутись в головне меню.");
                            Console.WriteLine("1 - змінити ім'я");
                            Console.WriteLine("2 - змінити призвіще");
                            Console.WriteLine("3 - змінити вік");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.WriteLine("Введіть ім'я об'єкту яке хочете змінити: ");
                                    string firstName=Console.ReadLine();
                                    Console.WriteLine("Введіть ім'я на яке хочете змінити: ");
                                    string secondName=Console.ReadLine();
                                    list.find_change_name(firstName, secondName);
                                    break;
                                case "2":
                                    Console.WriteLine("Введіть прізвище об'єкта, яке хочете змінити: ");
                                    string firstSurname=Console.ReadLine();
                                    Console.WriteLine("Введіть прізвище, на яке хочете змінити: ");
                                    string secondSurname=Console.ReadLine();
                                    list.find_change_surname(firstSurname, secondSurname);
                                    break;
                                case "3":
                                    Console.WriteLine("Введіть ім'я об'єкта чий вік ви хочете змінити: ");
                                    string Name=Console.ReadLine();
                                    Console.WriteLine("Введіть прізвище об'єкта чий вік ви хочете змінити: ");
                                    string SurName=Console.ReadLine();
                                    Console.WriteLine("Введіть вік, на який хочете змінити: ");
                                    int Age=int.Parse(Console.ReadLine());
                                    list.find_change_age(Name, SurName, Age);
                                    break;
                                default:
                                    Console.WriteLine("Ви ввели неправильний номер!");
                                    break;
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введіть ім'я об'єкта, який хочете видалити: ");
                        string name_human=Console.ReadLine();
                        Console.WriteLine("Введіть прізвище об'єкта, який хочете видалити: ");
                        string surName=Console.ReadLine();
                        list.remove(name_human, surName);
                        break;

                    default:
                        Console.WriteLine("Ви ввели неправильний номер!");
                        break;

                }
            }*/
            Console.ReadLine();
        }
    }
}