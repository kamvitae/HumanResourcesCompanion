using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    public class Worker
    {
        public int WorkerID { get; set; } 

        // można wprowadzić dodatkowego boola "currentlyEmployeed" <-- dawałby możliwość sortowania wg. obecnych/byłych pracowników

        public string LastName { get; set; }
        public string Name { get; set; }

        public string Hired{ get; set; }
        public string Fired{ get; set; }

        public decimal Salary { get; set; }

        public string Comments { get; set; }
    }
}
