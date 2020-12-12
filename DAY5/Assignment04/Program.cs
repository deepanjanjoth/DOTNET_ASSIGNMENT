using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr1 = new object[1];
            Employees[] arr = new Employees[3];
            Employees emp1 = new Employees(1, "Mohit", 1200000);
            Employees emp2 = new Employees(2, "Amit", 1200000);
            Employees emp3 = new Employees(3, "Jadu", 12000);



            arr[0] = emp1;
            arr[1] = emp2;
            arr[2] = emp3;

            // Console.WriteLine(((Employees)arr1[0]).EmpId);


            // Method 1
            //decimal[] tem = new decimal[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    tem[i] = arr[i].EmpSal;
            //}

            //Array.Sort(tem);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i].EmpSal == tem[2])
            //        Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName +"  "+arr[i].EmpSal);
            //}

            //Console.WriteLine(arr[arr.Length-1].EmpId + " " + arr[arr.Length - 1].EmpName + "  " + arr[arr.Length - 1].EmpSal);

            //Method 2
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employees temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }


            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }





            Console.ReadLine();
        }

    }

    class Employees
    {
        private int empId;

        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get;
            set;
        }
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }

        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

    }
}
        