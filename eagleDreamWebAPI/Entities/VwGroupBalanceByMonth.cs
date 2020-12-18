using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    public class VwGroupBalanceByMonth
    {

        public int gt_id { get; set; }

        public string gt_name { get; set; }

        public float ut_total_amount_per_month { get; set; }

        public string ut_month { get; set; }

    }

}
