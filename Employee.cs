using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee
    {
        public int Id { get; set; } // Egenskaper för employee
        public string Name { get; set; }
        public char Gender { get; set; }
        public double Salary { get; set; }

        public override bool Equals(object obj) // Överskrider Equals-metoden för att anpassa jämförelse
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return Id == other.Id && Name == other.Name && Gender == other.Gender && Salary == other.Salary;
        }

        public override int GetHashCode() // Överskrider GetHashCode-metoden
        {
            return HashCode.Combine(Id, Name, Gender, Salary);
        }
    }
}
