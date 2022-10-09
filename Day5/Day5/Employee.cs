using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Employee
    {
        public event

        EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)

        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public int VacationStock
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
    }
  

}
