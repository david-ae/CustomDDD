using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Staff : Person
    {
        protected Staff(Guid id) : base(id)
        {
        }

        public string? StaffNumber { get; set; }
    }
}
