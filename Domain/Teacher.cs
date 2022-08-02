using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Teacher : Staff
    {
        private IEnumerable<Pupil> pupils { get; set; }
    }
}
