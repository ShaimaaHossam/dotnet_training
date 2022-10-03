using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    [Flags]
    enum SecurityPrivileges
    {
        Guest = 2,
        Developer= 4,
        Secretary= 8,
        DBA = 16,
        Officer = Guest | Developer | Secretary | DBA

    };
}
