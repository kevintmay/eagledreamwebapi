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

    public class VwTransactionCountByMonthController : Controller
    {

        private DatabaseContext db;

        public VwTransactionCountByMonthController(DatabaseContext _db)
        {
            db = _db;
        }

        // GET: api/<VwTransactionCountByMonthController>
        [HttpGet]
        public IEnumerable<VwTransactionCountByMonth> Get()
        {
            var temp = db.VwTransactionCountByMonth.ToList();
            return temp;
        }
    }
}
