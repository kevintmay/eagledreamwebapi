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

    public class UserController : Controller
    {

        private DatabaseContext db;

        public UserController(DatabaseContext _db)
        {
            db = _db;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var temp = db.User.ToList();
            return temp;
        }

        // GET api/<UserController>/3
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var temp = db.User.Where(x => x.u_id == id).SingleOrDefault();
            return temp;
        }

        // GET api/<UserController/GetStatus/{status}
        [HttpGet]
        [Route("GetStatus/{status}")]
        public IEnumerable<User> Get(string status)
        {
            var temp = db.User.Where(x => x.u_status == status.ToUpper()).ToList();
            return temp;
        }

        // POST api/<UserController>/3
        [HttpPost]
        public void Post([FromBody] User data)
        {
            db.User.Add(data);
            db.SaveChanges();
        }

        // PUT api/<UserController>/3
        [HttpPost("{id}")]
        public void Put(int id, [FromBody] User data)
        {
            var temp = db.User.Where(x => x.u_id == id).SingleOrDefault();
            if(temp != null)
            {
                temp.u_first_name = data.u_first_name;
                temp.u_last_name = data.u_last_name;
                temp.u_name = data.u_name;
                temp.u_status = data.u_status;
            }

            db.User.Update(temp);
            db.SaveChanges();
        }

    }

}