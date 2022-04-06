using File_stream.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace File_stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files"); 

            if (!File.Exists(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json")) 
            {
                File.Create(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json");
            }

          
            Department department = new Department()
            {
                Id=1,
                Name="Ilknur"
                
                
            };
           
           

            //string result = JsonConvert.SerializeObject(department);
            //Console.WriteLine(result);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\TOSHIBA\Desktop\File stream\File stream\Files\Database.json"))
            //{
            //    sw.Write(result);

            //}
            //Department department1 = JsonConvert.DeserializeObject<Department>(result);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\TOSHIBA\Desktop\File stream\File stream\Files\Database.json"))
            //{
            //    Console.WriteLine(department1.Employees[0].ShowInfo());
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
                        
                           Employee employee = new Employee()
                           {
                               Id = id,
                               Name = name,
                               Salary = salary
                           };
                        department.Employees.Add(employee);
                        string result1 = JsonConvert.SerializeObject(department);
                        Console.WriteLine(result1);
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\TOSHIBA\Desktop\File stream\File stream\Files\Database.json"))
                        {
                            sw.Write(result1);

                        }

                        break;
                    case "2":

                        Console.WriteLine("Id:");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        string json = File.ReadAllText(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json");

                        using (StreamReader sw = new StreamReader(@"C:\Users\tu7knjupn\Desktop\File stream\File stream\Files\Database.json"))
                        {
                            json = sw.ReadToEnd();

                        }
                        Console.WriteLine(department.GetEmployeesById(1));
                        break;
                    case "3":
                   
                        Console.WriteLine($"Please enter your :");
                        string input = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.Clear();
                            Console.WriteLine("Input cannot be empty");

                        }
                     
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
