using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IRestaurantRepo
    {
        List<Restaurant> GetRestaurants(string category);
    }
}
