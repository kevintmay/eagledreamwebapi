using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eagleDreamWebAPI.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eagleDreamWebAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]

    public class VwGroupBalanceByMonthController : Controller
    {

        private DatabaseContext db;

        public VwGroupBalanceByMonthController(DatabaseContext _db)
        {
            db = _db;
        }

        // GET: api/<VwGroupBalanceByMonthController>
        [HttpGet]
        public IEnumerable<VwGroupBalanceByMonth> Get()
        {
            var temp = db.VwGroupBalanceByMonth.ToList();
            return temp;
        }
    }
}
