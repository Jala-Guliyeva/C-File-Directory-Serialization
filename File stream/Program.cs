using File_stream.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;

namespace File_stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files"); //files yazrig sonuna

            //if (!File.Exists(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json")) /bele bir fayl yoxdusa! yaratsin
            //{
            //    File.Create(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json");
            //}

            Employee employee1 = new Employee()
            {
                Id = 1,
                Name ="Jale",
                Salary=300

            };

            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "Konul",
                Salary = 200

            };


            Department department = new Department()
            {
                Id=1,
                Name="Ilknur"
                
            };
           
            department.Employees.Add(employee1);
            department.Employees.Add(employee2);



            //string result = JsonConvert.SerializeObject(department);
            //Console.WriteLine(result);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\TOSHIBA\Desktop\File stream\File stream\Files\Database.json"))
            //{
            //    sw.Write(result);

            //}

           


            //Console.WriteLine(result);
            //string result;
            //using (streamreader sw = new streamreader(@"c:\users\tu7knjupn\desktop\file stream\file stream\files\database.json"))
            //{
            //    result = sw.readtoend();
            //}
            bool check = true;
            do
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("1. Add employee ");
                Console.WriteLine("2. Get employee by id");
                Console.WriteLine("3. Remove employee");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Salary:");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        //Employee employee = new Employee();
                        //department.AddEmployee(employee);

                        string result = JsonConvert.SerializeObject(department);
                        Console.WriteLine(result);
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\TOSHIBA\Desktop\File stream\File stream\Files\Database.json"))
                        {
                            sw.Write(result);

                        }

                        break;
                    //case "2":
                    //    foreach (var item in user.GetAllStatuses())
                    //    {
                    //        Console.WriteLine(item.GetStatusInfo());
                    //    }
                    //    break;
                    case "2":
                        //Console.WriteLine("Id:");
                        //int id = Convert.ToInt32(Console.ReadLine());
                        //string json = File.ReadAllText(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json");
                        
                        //using (StreamReader sw = new StreamReader(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json"))
                        //{
                        //    json = sw.ReadToEnd();
 
                        //}
                        //Console.WriteLine(user.GetStatusById(id).GetStatusInfo());
                        break;

                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Not found!");
                        break;
                }

            } while (check);

        



        }  
    }
}
