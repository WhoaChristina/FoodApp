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

        public Restaurant GetRandom()
        {
            List<Restaurant> recs = new List<Restaurant>();
            var res = _repo.GetRandom();

            for (int i = 0; i < res.Count; i++)
            {
                if (res[i].HaveVisited && res[i].Rating > 6)
                {
                    recs.Add(res[i]);
                }
            }
            
            Random rnd = new Random();
            var pos = rnd.Next(0, recs.Count);
            
            return recs[pos];

        }

        public List<Restaurant> GetRestaurants(string category)
        {
            var res = _repo.GetRestaurants(category);
            return res;
        }
    }
}
