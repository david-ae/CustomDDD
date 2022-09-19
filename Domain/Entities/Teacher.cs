using CustomDDD.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDDD.Domain.Entities
{
    public class Teacher : Staff
    {
        public Teacher(Guid id) : base(id)
        {
        }

        private IEnumerable<Pupil>? pupils { get; set; }
    }
}
