using FoodApp.Models;
using FoodApp.Services.Interfaces;
using FoodApp.Repositories.Interfaces;
using FoodApp.Repositories;

namespace FoodApp.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepo _repo;

        public RestaurantService(IRestaurantRepo repo)
        {
            _repo = repo;
        }

        public List<Restaurant> GetRestaurants(string category)
        {
            var res = _repo.GetRestaurants(category);
            return res;
        }
    }
}
