using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Services.Interfaces;
using FoodApp.Services;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishesService _dishesService;

        public DishesController(IDishesService dishesService)
        {
            _dishesService = dishesService;
        }

        [HttpGet]
        [Route("api/[action]")]
        public IActionResult GetDishes(int restaurant)
        {
            try
            {
                var res = _dishesService.GetDishes(restaurant);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
