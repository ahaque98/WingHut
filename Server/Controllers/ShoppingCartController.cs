using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Models.Response;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ApiResponse _response;
        public ShoppingCartController(ApplicationDbContext db)
        {
            _response = new();
            _db = db;
        }

        [HttpPost]
        public Task<ActionResult<ApiResponse>> AddOrUpdateItemsInCart(
            string userId, int menuItemId, int updateQuantityBy
            )
        {

        }
    }
}
