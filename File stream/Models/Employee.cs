using System;
using System.Collections.Generic;
using System.Text;

namespace File_stream.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        

        public string ShowInfo()
        {
            return $"Id:{Id} - Name:{Name} - Salary:{Salary}";
        }
    }
}
