using System.Drawing;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] EmpArr = ScanInputs();

            Console.WriteLine("Before Sorting");
            PrintEmployees(EmpArr);
            
            EmpArr = EmpArr.OrderBy(y => y.HireDate.year)
                .ThenBy(m=>m.HireDate.month).ThenBy(d => d.HireDate.day).ToArray();


            Console.WriteLine("After Sorting");
            PrintEmployees(EmpArr);



        }
        private static void PrintEmployees(Employee[] EmpArr)
        {
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }
        }


        public static Employee[] ScanInputs()
        {

            Employee[] EmpArr = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                string ID = GetID();
                string securityPriv = GetSecurityPriv();
                string HireDay = GetHireDate("Day");
                string HireMonth = GetHireDate("Month");
                string HireYear = GetHireDate("Year");
                string gender = GetGender();
                decimal salary = GetSalary();

                Employee employee = new Employee(ID, securityPriv, HireDay, HireMonth, HireYear, gender, salary);
                EmpArr[i] = employee;
            }

            return EmpArr;
        }
        public static decimal GetSalary()
        {
            Console.WriteLine("Please enter your Salary: ");
            while (true)
            {
                string sal = Console.ReadLine();
                decimal salary = 0.0m;
                bool canCovert = decimal.TryParse(sal, out salary);

                if (!canCovert)
                {
                    Console.WriteLine("Please enter a valid number:");
                    continue;
                }

                return salary;
            }
        }

        public static string GetGender()
        {
            Console.WriteLine("Please enter your gender: { M - F }");
            while (true)
            {
                string g = Console.ReadLine();
                if(!Enum.IsDefined(typeof(Gender), g))
                {
                    Console.WriteLine("Please enter a valid gender: { M - F }");
                    continue;
                }
                return g;
            }
        }

        public static string GetHireDate(string type)
        {
            int upperlimit;
            int lowerlimit;
            if (type == "Day")
            {
                upperlimit = 31;
                lowerlimit = 1;
            }
            else if (type == "Month")
            {
                upperlimit = 12;
                lowerlimit = 1;
            }
            else
            {
                upperlimit = 2022;
                lowerlimit = 1998;
            }

            Console.WriteLine($"Enter Hire {type} : from {lowerlimit} to {upperlimit}");
            while (true)
            {
                int d = 0;
                string val = Console.ReadLine();
                bool canConvert = int.TryParse(val, out d);
                if (!canConvert || d > upperlimit || d < lowerlimit)
                {
                    Console.WriteLine($"Please enter a valid  {type} :  from {lowerlimit} to {upperlimit}");
                    continue;
                }

                return val;
            }

        }
        public static string GetID()
        {
            Console.WriteLine("Enter ID: ");
            return Console.ReadLine();
        }
        private static string GetSecurityPriv()
        {
            Console.WriteLine("Enter Privilege: { DBA, Guest, Secretary, Developer, Officer upper}");
            while (true)
            {
                string securityPriv = Console.ReadLine();
                if (!Enum.IsDefined(typeof(SecurityPrivileges), securityPriv))
                {
                    Console.WriteLine("Please enter a valid privilege { DBA, Guest, Secretary, Developer, Officer}");

                    continue;
                }

                return securityPriv;
            }
        }

    }

}