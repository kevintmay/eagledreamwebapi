using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    public class VwTransactionCountByMonth
    {

        public int tt_id { get; set; }

        public string tt_name { get; set; }

        public int tt_total_number_of_transactions { get; set; }

        public string ut_month { get; set; }

    }

}
