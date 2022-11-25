using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11Task.Models
{
    internal class Assistant
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull == true)
            {
                Console.WriteLine(employee.IsSuccessfull);
            }
            else
            {
                Console.WriteLine("Uzerinde Birazda calis");
            }
        }
    }
}
