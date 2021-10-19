using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUtilities
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public ScheduleDays Availability { get; set; }
        public JobCodes JobsKnown { get; set; }

    }
}
