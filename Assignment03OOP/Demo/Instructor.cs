using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Instructor : ICloneable, IComparable
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }


        public Instructor(Instructor Ins)
        {
            this.ID = Ins.ID;
            this.Name = Ins.Name;
            this.Salary = Ins.Salary;
        }

        public Instructor()
        {
            
        }

        public object Clone()
        {
            return new Instructor(this);
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name} , ID : {ID} ");
        }

        public override string ToString()
        {
            return $"ID : {ID} , Name : {Name} , Salary : {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Instructor Temp = (Instructor)obj;   // Un Safe Casting

            if(this.Salary > Temp.Salary)
            {
                return 1;
            }
            else if (this.Salary < Temp.Salary)
            {
                return -1;
            }

            return 0;
        }
    }
}
