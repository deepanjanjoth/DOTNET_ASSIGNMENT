using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Employee o1 = new Employee("Deepanjan", 123465, 10);
            Employee o2 = new Employee("Deepanjan", 123465);
            Employee o3 = new Employee("Deepanjan");
            Employee o4 = new Employee();

            Console.WriteLine(o1.getNetSalary());

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.ReadLine();
        }

    }

    class Employee
    {
        #region Properties

        private string empName;
        private int empNo;
        private decimal basicSalary;
        private short deptNo;
        static int id = 0;


        static Employee()
        {
            //empNo = 0;
        }
        public Employee(string empName = "null1", decimal basicSalary = 0, short deptNo = 0)
        {
            id++;
            //this.empName = empName;
            this.EmpName = EmpName;
            //this.basicSalary = basicSalary;
            //this.deptNo = deptNo;
            this.BasicSalary = basicSalary;
            this.DeptNo = deptNo;
            this.empNo = id;
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value == null)
                {
                    // Console.WriteLine("NOt Invalid Name !!");
                    empName = value;
                }
                else
                    Console.WriteLine("Invalid Name !!");


            }
        }
        public int EmpNo
        {
            get { return empNo; }
        }

        public decimal BasicSalary
        {
            get { return basicSalary; }
            set
            {
                if (value > 1000 && value < 1000000)
                    basicSalary = value;
                else
                    Console.WriteLine("Invalid salary !!");
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid Depatment Number !!");
            }
        }

        public decimal getNetSalary()
        {
            double deduction = 1000;
            decimal salary = basicSalary - (decimal)deduction;
            return salary;
        }

        #endregion
    }

}
