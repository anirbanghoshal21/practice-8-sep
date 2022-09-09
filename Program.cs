using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_driven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Ram",
                DeptNo = 12,
                Salary = 32456,
                Manager = "Deepak"
            };

            Employee emp2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Avi",
                DeptNo = 14,
                Salary = 29276,
                Manager = "Aman"
            };
            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            EligibleToPromotion eligibleTopromote = new EligibleToPromotion(Program.Promote);
            Employee.PromoteEmployee(lstEmployess, eligibleTopromote);
            Console.ReadKey();
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
