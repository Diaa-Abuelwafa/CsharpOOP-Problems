using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct PhoneBook
    {
        string[] names;
        long[] phones;
        int size;

        public PhoneBook(int Size)
        {
            size = Size;
            names = new string[Size];
            phones = new long[Size];
        }

        public string this[int Indx]
        {
            get
            {
                if(Indx < size)
                {
                    return names[Indx];
                }
                else
                {
                    return "This Out Of Range";
                }
            }

            set
            {
                if (Indx < size)
                {
                    names[Indx] = value;
                }
                else
                {
                    Console.WriteLine("This Out Of Range");
                }
            }
        }

        public long this[string Name]
        {
            get
            {
                for(int i = 0; i < names.Length; ++i)
                {
                    if(Name == names[i])
                    {
                        return phones[i];
                    }
                }

                return -1;
            }

            set
            {
                for(int i = 0; i < names.Length; ++i)
                {
                    if (Name == names[i])
                    {
                        phones[i] = value;
                        return;
                    }
                }
            }
        }
    }
}
