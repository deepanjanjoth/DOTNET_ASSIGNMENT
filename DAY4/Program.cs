using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Employee=================");
            Employee a1 = new Manager("Employee", "ABC", 10000, 01);
            a1.DisplayData();
            Console.ReadLine();


            Console.WriteLine("===============Manager=================");
            Employee a2 = new Manager("Manager", "Deepanjan", 30000, 11);
            a2.DisplayData();
            Console.ReadLine();

            Console.WriteLine("============GenerelManager=================");
            Employee a3 = new GenerelManager("Derimilk", "general manager", "Mohit", 50000, 12);
            a3.DisplayData();
            Console.ReadLine();


            Console.WriteLine("=================CEO=================");
            CEO a4 = new CEO("Rahul", 80000, 13);
            a4.DisplayData();


            Console.ReadLine();

        }
    }

    public interface IDbFunctions
    {
        #region Methods to be Implemented
        void Insert();
        void Update();
        void Delete();
        #endregion
    }


    public abstract class Employee : IDbFunctions
    {
        #region Properties
        private string name;
        public string Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter a Correct Name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        // private static int lastEmpNo = 0;
        private static int empNo = 0;
        public int EmpNo
        {
            get;

            private set;
        }

        private decimal basic;
        public abstract decimal Basic { get; set; }


        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Depart no should be greater then 0");
                }
                else
                {
                    deptNo = value;
                }

            }
            get
            {
                return deptNo;
            }
        }
        #endregion

        #region Constructor
        public Employee(string name = "Rahul", decimal basic = 2500, short deptNo = 10)
        {
            this.EmpNo = ++empNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        #endregion

        #region Methods
        public abstract decimal CalcNetSalary();

        public virtual void DisplayData()
        {
            Console.WriteLine("Employee Id : " + EmpNo);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Employee department : " + DeptNo);
            //Console.WriteLine("Employee designation : " + designation);
            Console.WriteLine("===========================================");
        }



        public abstract void Insert();


        public abstract void Update();

        public abstract void Delete();

        #endregion
    }


    public class Manager : Employee
    {
        #region Data Members
        public int BASIS, DA, HRA;
        public decimal GROSS;
        #endregion

        #region Properties
        public override decimal Basic { get; set; }


        private string designation;
        public string Designation
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Designation should not be empty");
                }
                else
                {
                    designation = value;
                }
            }
            get
            {
                return designation;
            }
        }
        #endregion

        #region Constructor

        public Manager(string designation = "manager", string name = "Rahul", decimal basic = 2500, short deptNo = 10) : base(name, basic, deptNo)
        {
            this.Designation = designation;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        #endregion

        #region Methods
        public override decimal CalcNetSalary()
        {
            BASIS = Convert.ToInt32(this.Basic);
            DA = (int)(0.4 * BASIS);
            HRA = (int)(0.3 * BASIS);
            GROSS = Basic + DA + HRA;
            return GROSS;
        }
        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("Employee designation : " + designation);
            Console.WriteLine("Employee Salaary : " + CalcNetSalary());
            Console.WriteLine("===========================================");
        }

        public override void Insert()
        {
            Console.WriteLine("Insert Manager data to DB.");
        }

        public override void Update()
        {
            Console.WriteLine("Update Manager data to DB.");
        }

        public override void Delete()
        {
            Console.WriteLine("Insert Delete data to DB.");
        }
        #endregion
    }

    public class GenerelManager : Manager
    {
        #region Properties
        private string perks;
        public string Perks
        {
            get; set;
        }

        #endregion

        #region Constructor
        public GenerelManager(string perks = "KitKat", string designation = "manager", string name = "Rahul", decimal basic = 2500, short deptNo = 10) : base(designation, name, basic, deptNo)
        {
            this.Perks = perks;
            this.Designation = designation;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        #endregion

        #region Methods
        public override decimal CalcNetSalary()
        {
            BASIS = Convert.ToInt32(this.Basic);
            DA = (int)(0.4 * BASIS);
            HRA = (int)(0.3 * BASIS);
            GROSS = Basic + DA + HRA + 500;
            return GROSS;
        }
        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("Employee  perks : " + Perks);
            Console.WriteLine("===========================================");
        }

        public override void Insert()
        {
            base.Insert();
            Console.WriteLine("Insert Generel Manager data to DB.");
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine("Update Generel Manager data to DB.");
        }

        public override void Delete()
        {
            base.Delete();
            Console.WriteLine("Delete Generel Manager data to DB.");
        }
        #endregion
    }

    public class CEO : Employee
    {
        #region Properties
        public override decimal Basic { get; set; }
        #endregion

        #region Constructor
        public CEO(string name = "Rahul", decimal basic = 5000, short deptNo = 100) : base(name, basic, deptNo)
        {
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        #endregion

        #region Data Member
        public int BASIS, DA, HRA;
        public decimal GROSS;
        #endregion

        #region Methods
        public override decimal CalcNetSalary()
        {
            BASIS = Convert.ToInt32(this.Basic);
            DA = (int)(0.5 * BASIS);
            HRA = (int)(0.4 * BASIS);
            GROSS = Basic + DA + HRA;
            return GROSS;
        }

        public override sealed void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("CEO  Sal : " + CalcNetSalary());
            Console.WriteLine("===========================================");
        }
        public override void Insert()
        {
            Console.WriteLine("Insert CEO data to DB.");
        }

        public override void Update()
        {
            Console.WriteLine("Update CEO data to DB.");
        }

        public override void Delete()
        {
            Console.WriteLine("Delete CEO data to DB.");
        }
        #endregion
    }
}