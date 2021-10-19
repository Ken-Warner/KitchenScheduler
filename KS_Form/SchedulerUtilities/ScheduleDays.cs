using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUtilities
{
    /// <summary>
    /// Flags representing each of the 14 days in a biweekly scheduling period.
    /// </summary>
    [Flags][Serializable]
    public enum ScheduleDays : ushort
    {
        Sunday1     = 0b_1,
        Monday1     = 0b_10,
        Tusday1     = 0b_100,
        Wednesday1  = 0b_1000,
        Thursday1   = 0b_10000,
        Friday1     = 0b_100000,
        Saturday1   = 0b_1000000,

        Sunday2     = 0b_10000000,
        Monday2     = 0b_1_00000000,
        Tuesday2    = 0b_10_00000000,
        Wednesday2  = 0b_100_00000000,
        Thursday2   = 0b_1000_00000000,
        Friday2     = 0b_10000_00000000,
        Saturday2   = 0b_100000_00000000
    }
}
