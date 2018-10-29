using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ShoppingController : Controller
    {
        public static Dictionary<string, List<ShoppingItems>> ShoppingItems { get; set; } = new Dictionary<string, List<ShoppingItems>>();
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(List<ShoppingItems>), 200)]
        public IActionResult Get([FromQuery] string apikey)
        {
            apikey = "1";
            if (!ShoppingItems.ContainsKey(apikey)) ShoppingItems[apikey] = new List<ShoppingItems>
            {
                new ShoppingItems("Apple", 5, Guid.NewGuid())
            };
            return Ok(ShoppingItems[apikey]);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(ShoppingItems), 200)]
        public IActionResult Post([FromQuery]string apikey, [FromBody] ShoppingItems item)
        {
            apikey = "1";
            if (!ShoppingItems.ContainsKey(apikey)) ShoppingItems[apikey] = new List<ShoppingItems>
            {
                new ShoppingItems("Bread", 4, Guid.NewGuid())
            };
            var shopItem = new ShoppingItems(item.Name, item.Price, Guid.NewGuid());
            ShoppingItems[apikey].Add(shopItem);
            return Ok(shopItem);
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
