using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum security
    {
        Guest, Developer, Secretary, DBA
    }
    internal class Employee
    {
        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        private static int _ID;
        public string Name { set; get; }
        private double salary;
        public security Security { get; }
        private char gender ;
        public  hiringDate hiringDate { get; set; }

        public Employee(string name,int iD,double sal,string sec,string g,  hiringDate hir)
        {
            Name = name;
            ID  = iD;
            Salary = sal;
            secur=sec;
            Gender = g;
             hiringDate= hir;


       
        }
        public int ID
        {
            set
            {
                if (value < 0) {
                    throw new ArgumentException("invalid ID");
                }
                else _ID = value;
            }
            get {
                return _ID;
            }
        }
        public string secur
        {
            set
            {
                if (Enum.TryParse(value, out security security)) { }
                else
                {
                    throw new Exception("invalid security");
                }                    
            }           
        }

        public string Gender
        {
            set
            {
                if ( value == "M" || value == "F")
                    gender = value[0];
                else
                {
                    throw new Exception("Invalid gender");
                }
            }
            get
            {
                return gender.ToString();
            }
        }
        public double Salary
        {
            set
            {
                if (value >= 4000)
                {
                    salary = value;
                }
                else
                    throw new Exception("invalid salary");
            }
            get  { return salary; }
        }

        public override string ToString()
        {
            return string.Format("emp id  {0} name is {1} security {2} gender {3} salary {4} ", _ID,Name, Security,gender,salary);
        }
    }
}
