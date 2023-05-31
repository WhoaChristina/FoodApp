using FoodApp.Models;
namespace FoodApp.Services.Interfaces
{
    public interface IRestaurantService
    {
        List<Restaurant> GetRestaurants(string category);
        Restaurant GetRandom();
    }
}
