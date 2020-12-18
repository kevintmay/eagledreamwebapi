using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    [Table("Transaction_Type")]
    public class TransactionType
    {

        public int tt_id { get; set; }

        public string tt_name { get; set; }

        public string tt_display_name { get; set; }

        public string tt_status { get; set; }

    }

}
