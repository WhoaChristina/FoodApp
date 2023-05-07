using System;
using System.Collections.Generic;

namespace FoodApp.Models;

public partial class Dish
{
    public int RestaurantId { get; set; }

    public string Name { get; set; } = null!;

    public string Ingredients { get; set; } = null!;

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;
}
