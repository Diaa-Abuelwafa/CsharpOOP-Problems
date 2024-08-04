using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Empolyee
    {
        private int id;
        private int age;
        private int salary;

        // Setter Method
        public void SetId(int _id)
        {
            this.id = _id;
        }

        // Getter Method
        public int GetId()
        {
            return this.id;
        }

        // Setter Method
        public void SetAge(int _age)
        {
            this.age = _age;
        }

        // Getter Method
        public int GetAge()
        {
            return this.age;
        }

        // Setter Method
        public void SetSalary(int _salary)
        {
            // Protective Code & Validation
            if(_salary > 3000)
            {
                this.salary = _salary;
            }
            else
            {
                this.salary = 3000;
            }
        }

        // Getter Method
        public int GetSalary()
        {
            return this.salary;
        }
    }
}
