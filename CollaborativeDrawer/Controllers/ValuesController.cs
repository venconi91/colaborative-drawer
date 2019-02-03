using System.Collections.Generic;
using CollaborativeDrawer.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CollaborativeDrawer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly DrawerContext context;

    public ValuesController(DrawerContext context)
    {
      this.context = context;
    }
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Post>> Get()
    {
      return context.Posts.ToList();

        //return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
