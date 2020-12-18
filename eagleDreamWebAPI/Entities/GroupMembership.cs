using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{

    [Table("Group_Membership")]
    public class GroupMembership
    {
        [ForeignKey("User")]
        public int gm_user_id { get; set; }

        public int gm_group_type_id { get; set; }

    }

}
