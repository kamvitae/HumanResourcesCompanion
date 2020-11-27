﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    public class Worker
    {
        //private string _name;
//
        //public Worker(string name)
       //{
        //    this._name = name;
        //}
        public int WorkerID { get; set; } 

        // można wprowadzić dodatkowego boola "currentlyEmployeed" <-- dawałby możliwość sortowania wg. obecnych/byłych pracowników

        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime Hired{ get; set; }
        public DateTime Fired{ get; set; }

        public decimal Salary { get; set; }

        public string Comments { get; set; }
    }
}
