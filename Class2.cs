using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);

    public class Employee
    {
    }

    public class employee
    {
        private int _empid;

        public int EmpId
        {
            get { return _empid; }
            set { _empid = value; }
        }
        private string _empname;

        public string Empname
        {
            get { return _empname; }
            set { _empname = value; }
        }

        private int _deptno;

        public int Deptno
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private float _sal;

        public float Sal
        {
            get { return _sal; }
            set { _sal = value; }
        }

        private string _mgr;

        public string Mgr
        {
            get { return _mgr; }
            set { _mgr = value; }
        }
        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);

                }
}
