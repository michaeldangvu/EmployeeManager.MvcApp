using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Mvc.Models
{
    public class Country
    {
        // using built-in conventions rather than data annotations like Employee.cs
        public int CountryID { get; set; }
        public string Name { get; set; }
    }
}
