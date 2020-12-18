using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Models
{
    public class UserTransactionModel
    {
        public int ut_id { get; set; }

        public int ut_user_id { get; set; }

        public int ut_transaction_type_id { get; set; }

        public string ut_description { get; set; }

        public float ut_amount { get; set; }

        public string ut_timestamp { get; set; }
    }

}