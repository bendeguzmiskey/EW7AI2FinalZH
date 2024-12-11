using cseresznye_ew7ai2.F1Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cseresznye_ew7ai2.Controllers
{
        [Route("api/f1")]
        [ApiController]
        public class F1Controller : ControllerBase
        {
            // GET: api/<F1Controller>
            [HttpGet]
            public IActionResult Get()
            {
                Forma1Context context = new Forma1Context();
                return Ok(context.Pilota.ToList());
            }

            // GET api/<F1Controller>/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                Forma1Context context = new Forma1Context();
                var driver = (from x in context.Pilota
                              where x.PilotaId == id
                              select x).FirstOrDefault();
                return Ok(driver);
            }

            // POST api/<F1Controller>
            [HttpPost]
            public void Post([FromBody] Pilota newdriver)
            {
                Forma1Context context = new Forma1Context();
                context.Pilota.Add(newdriver);
                context.SaveChanges();
            }

            // PUT api/<F1Controller>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<F1Controller>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                Forma1Context context = new Forma1Context();
                var deleteDriver = (from x in context.Pilota
                                    where x.PilotaId == id
                                    select x).FirstOrDefault();
                context.Remove(deleteDriver);
                context.SaveChanges();
            }
        }
    }
