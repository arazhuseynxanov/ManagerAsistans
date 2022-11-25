using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11Task.Models
{
    public class Employee
    {
        private string _name;
        private bool _isSuccessfull;
        private float _salary;

        public Employee(string name, bool isSuccessfull, float salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool IsSuccessfull
        {
            get { return _isSuccessfull; }
            set
            {
                bool result=false;
                if (value == true)
                {
                   _isSuccessfull=value;
                    
                    
                }
                result = false;

            }
        }
        public float Salary
        {
            get { return _salary; }
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
            }
        }
    }
}
