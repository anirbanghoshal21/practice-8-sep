using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace department
{
    public delegate Employeedelegate(int emp1id, int emp2id);
    public static void main(int dept)
    {
        int emp1id, emp2id;

        Console.Write("\n\n");
        Console.Write("Employee data in department");
        Console.Write("---------------------------");



        Console.Write("Enter the first employee id :");
        emp1id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second second id :");
        emp2id = Convert.ToInt32(Console.ReadLine());


        Console.Write("\nHere are the options :\n");
        Console.Write("1-Add.\n2-edit.\n3-update.\n4-delete.\n5-Exit.\n");
        Console.Write("\nInput your choice :");
        dept = Convert.ToInt32(Console.ReadLine());

        switch (dept)
        {
            case 1:
                Console.Write("Add the data from dept");
                break;

            case 2:
                Console.Write("Edit the data from dept");
                break;

            case 3:
                Console.Write("Update the data from dept");
                break;

            case 4:

                Console.WriteLine("Deleted");
            case 5:
                break;

            default:
                Console.Write("Input correct option\n");
                break;
        }
        
    }
}
