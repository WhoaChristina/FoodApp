using System;
using System.Collections.Generic;

namespace FoodApp.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsInBusiness { get; set; }

    public bool HaveVisited { get; set; }

    public int Rating { get; set; }

    public string Category { get; set; } = null!;

    public string? Comment { get; set; }
}
