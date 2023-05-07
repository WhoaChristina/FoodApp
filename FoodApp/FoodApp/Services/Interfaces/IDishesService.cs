using FoodApp.Models;
namespace FoodApp.Services.Interfaces
{
    public interface IDishesService
    {
        List<Dish> GetDishes(int restaurantId);
    }
}
