using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUtilities
{
    /// <summary>
    /// Class representing the various positions in the kitchen, when they need to be occupied, and the primary employees occupying them.
    /// </summary>
    public class Position
    {
        //name of the position
        public string Name { get; set; }

        //brief description of the position's duties
        public string Description { get; set; }

        //Job Code of the position
        public JobCodes JobCode { get; set; }

        //Days this position needs to be occupied
        public ScheduleDays DaysRequired { get; set; }

        //primary employee occupying this position
        public Employee PrimaryEmployee { get; set; }
    }
}
