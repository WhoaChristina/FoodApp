using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IDishesRepo
    {
        List<Dish> GetDishes(int restaurantId);
    }
}
