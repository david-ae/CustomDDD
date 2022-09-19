using CustomDDD.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDDD.Domain.Entities
{
    public class Pupil : Person
    {
        public Pupil(Guid id) : base(id)
        {
        }

        public IEnumerable<object>? ClassHistory { get; private set; }
        public string? CurrentClass { get; private set; }
        public int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
