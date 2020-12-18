using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Models
{
    public class VwUserTransactionsTotalByMonthAllModel
    {
        // Model of database view
        public int u_id { get; set; }

        public string u_first_name { get; set; }

        public string u_last_name { get; set; }

        public string u_full_name { get; set; }

        public float ut_account_balance { get; set; }

        public string ut_month { get; set; }
    }

}