using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    [Flags]
    enum SecurityPrivileges
    {
        Guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8
    }
    internal class Employee
    {
        DateTime hire_date;

        // Setter & Getter id Using Automatic Property
        public int Id { get; set; }

        // Setter & Getter salary Using Automatic Property
        public int Salary { get; set; }

        // Setter & Getter name Using Automatic Property
        public string Name { get; set; }

        // Setter & Getter gender Using Full Property
        char gender;
        public char Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if(value == 'M' || value == 'F')
                {
                    this.gender = value;
                }
                else
                {
                    this.gender = 'M';
                }
            }
        }

        // Setter & Getter Security_Level Using Full Property
        SecurityPrivileges security_level;
        public string SecurityLevel
        {
            get
            {
                if((int)this.security_level == 1)
                {
                    return "Guest";
                }
                else if((int)this.security_level == 8)
                {
                    return "DBA";
                }
                else if ((int)this.security_level == 15)
                {
                    return "Guest Developer secretary DBA";
                }
                else
                {
                    return "No";
                }
            }

            set
            {
                if (value == "DBA")
                {
                    this.security_level = SecurityPrivileges.DBA;
                }
                else if (value == "Guest")
                {
                    this.security_level = SecurityPrivileges.Guest;
                }
                else if (value == "security officer")
                {
                    this.security_level = SecurityPrivileges.DBA;
                    this.security_level |= SecurityPrivileges.Developer;
                    this.security_level |= SecurityPrivileges.secretary;
                    this.security_level |= SecurityPrivileges.Guest;

                }
            }
        }

        // Setter & Getter HireDate Using Automatic Property
        public DateOnly HireDate { get; set; }


        public Employee(int _id, int _salary, string _name, DateOnly _hire_date)
        {
            Id = _id;
            Salary = _salary;
            Name = _name;
            HireDate = _hire_date;
        }

        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1} Securitylevel: {2} Salary: {3} HireDate: {4} Gender: {5}", Id, Name, security_level, HireDate, Salary, Gender);
        }
    }
}
