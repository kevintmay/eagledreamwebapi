using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Models
{
    public class TransactionTypeModel
    {
        public int tt_id { get; set; }

        public string tt_name { get; set; }

        public string tt_display_name { get; set; }

        public string tt_status { get; set; }
    }

}