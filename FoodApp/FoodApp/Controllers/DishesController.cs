using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Services.Interfaces;
using FoodApp.Services;

namespace FoodApp.Controllers
{
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishesService _dishesService;

        public DishesController(IDishesService dishesService)
        {
            _dishesService = dishesService;
        }

        [HttpGet]
        [Route("api/[action]/{id}")]
        public IActionResult GetDishes(int id)
        {
            try
            {
                var res = _dishesService.GetDishes(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
