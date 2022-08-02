using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pupil : Person
    {
        public IEnumerable<object> ClassHistory { get; set; }
        public string CurrentClass { get; set; }
        public int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
