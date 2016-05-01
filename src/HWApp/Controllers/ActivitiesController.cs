using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HWApp.Models;
using HWApp.Services.Concrete;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HWApp.Controllers
{
	[Route("api/[controller]")]
    public class ActivitiesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Activity>> Get()
        {
			return await MongoDbService.Instance.GetActivities();			 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
