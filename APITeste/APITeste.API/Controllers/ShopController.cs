using APITeste.Domain.Models;
using APITeste.Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APITeste.API.Controllers
{
    [ApiController]
    [Route("api/v1/shop")]
    public class ShopController : ControllerBase
    {
        public IShopRepository repo { get; set; }
        public ShopController(IShopRepository r)
        {
            repo = r;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Shop shop)
        {
            shop = repo.Post(shop);
            return Ok(shop);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Shop shop)
        {
            repo.Put(shop);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get([FromQuery] Shop shop)
        {
            var result = repo.Get(shop);
            return Ok(result);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            repo.Delete(Id);
            return Ok();
        }
    }
}
