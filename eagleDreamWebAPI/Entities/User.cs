using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    [Table("User")]
    public class User
    {
        public int u_id { get; set; }

        public string u_name { get; set; }

        public string u_first_name { get; set; }

        public string u_last_name { get; set; }

        public string u_status { get; set; }

    }

}
