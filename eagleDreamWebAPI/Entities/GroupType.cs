using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    [Table("Group_Type")]
    public class GroupType
    {

        public int gt_id { get; set; }

        public string gt_name { get; set; }

        public string gt_display_name { get; set; }

        public string gt_status { get; set; }

    }

}
