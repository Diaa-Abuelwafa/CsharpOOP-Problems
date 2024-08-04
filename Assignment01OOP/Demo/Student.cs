using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Student
    {
        int id;
        string name;
        int salary;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                id = value; // Reserved Word refer to Value i set at object
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                this.salary = value;
            }
        }

        public Student(int _id, string _name, int _salary)
        {
            // Here I Assign Properties No Atrributes So After Validation
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
    }
}
