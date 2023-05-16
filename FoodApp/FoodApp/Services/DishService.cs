using FoodApp.Models;
using FoodApp.Services.Interfaces;
using FoodApp.Repositories.Interfaces;
using FoodApp.Repositories;

namespace FoodApp.Services
{
    public class DishService : IDishesService
    {
        private readonly IDishesRepo _repo;

        public DishService(IDishesRepo repo)
        {
            _repo = repo;
        }

        public List<Dish> GetDishes(int id)
        {
            var res = _repo.GetDishes(id);
            return res;
        }
    }
}
