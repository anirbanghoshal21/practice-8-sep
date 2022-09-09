using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace department
{

    public delegate void Logindelegate(string ename);
    public class employees
    {
        public static event Logindelegate instructions;

        public int Userid { get; set; }
        public string password { get; set; }
        public void Settings(int Userid)
        {
            Login += Login_Employee;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Userid is correct");
            }
            else
            {
                Console.WriteLine("Userid is incorrect");
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Password is correct");
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }

            private void Login_Employee(int userid,string password)
            {
                
                Logindelegate del = new Logindelegate(login);
                del.Invoke(Settings);


            }
        }
    
}

