using FoodApp.Repositories.Interfaces;
using FoodApp.Models;

namespace FoodApp.Repositories
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private readonly RestaurantDbContext _context;

        public RestaurantRepo(RestaurantDbContext context)
        {
            _context = context;
        }

        public List<Restaurant> GetRandom()
        {
            return _context.Restaurants.ToList();
        }

        List<Restaurant> IRestaurantRepo.GetRestaurants(string category)
        {
            return _context.Restaurants.Where(x => x.Category == category).ToList();
        }
    }
}
