using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP1
{
    [Flags]
    internal enum Permissions
    {
        Delete=1,
        Execute=2,
        Read=4,
        Write=8
    }
}
