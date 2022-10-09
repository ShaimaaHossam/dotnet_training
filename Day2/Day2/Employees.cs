using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    struct Employee : IComparable<Employee>
    {
        public string ID { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender gender { get; set; }
        public decimal Salary { get; set; }
        public Employee(string id, string securityLevel, string day, string month, string year, string gender, decimal salary  )
        {
            ID = id;
            HireDate = new HiringDate(day, month, year);
            SecurityLevel = (SecurityPrivileges)Enum.Parse(typeof(SecurityPrivileges), securityLevel);
            this.gender = (Gender)Enum.Parse(typeof(Gender), gender);
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ID: {ID} " +
                    $"\nSecurity Privileges: {SecurityLevel}\n" +
                    $"Hire Date: {HireDate.day}/{HireDate.month}/{HireDate.year}" +
                    $"\nGender: {gender}" +
                    $"\nSalary: {String.Format("{0:C}",Salary)}";

        }

        public int CompareTo(Employee other)
        {
            if(HireDate.year.CompareTo(other.HireDate.year) == 0)
            {
                if(HireDate.month.CompareTo(other.HireDate.month) == 0)
                {
                    return HireDate.day.CompareTo(other.HireDate.day);
                }
                return HireDate.month.CompareTo(other.HireDate.month);
            }

            return HireDate.year.CompareTo(other.HireDate.year);
        }
    }

    
}
