using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Services.Interfaces;
using FoodApp.Services;

namespace FoodApp.Controllers
{
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        [Route("api/[action]/{category}")]
        public IActionResult GetRestaurants(string category)
        {
            try
            {
                var res = _restaurantService.GetRestaurants(category);
                return Ok(res);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/[action]")]
        public IActionResult GetRandom()
        {
            try
            {
                var res = _restaurantService.GetRandom();
            return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
