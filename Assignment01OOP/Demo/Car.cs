using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        int id;
        string model;
        long serial;

        public Car(int _id, string _model, long _serial) : this(_id, _model) // Internal Constructor Chaining
        {
            serial = _serial;
        }

        public Car(int _id, string _model)
        {
            id = _id;
            model = _model;
        }
    }
}
