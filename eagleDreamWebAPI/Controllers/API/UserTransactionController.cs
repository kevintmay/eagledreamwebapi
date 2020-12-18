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

    public class UserTransactionController : Controller
    {

        private DatabaseContext db;

        public UserTransactionController(DatabaseContext _db)
        {
            db = _db;
        }

        // GET: api/<UserTransactionController>
        [HttpGet]
        public IEnumerable<UserTransaction> Get()
        {
            var temp = db.UserTransaction.ToList();
            return temp;
        }
    }
}
