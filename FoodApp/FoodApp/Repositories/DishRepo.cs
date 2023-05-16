using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories
{
    public class DishRepo : IDishesRepo
    {
        private readonly RestaurantDbContext _context;

        public DishRepo(RestaurantDbContext context)
        {
            _context = context;
        }
        public List<Dish> GetDishes(int id)
        {
            return _context.Dishes.Where(d => d.RestaurantId == id).ToList();
        }
    }
}
