using System.Collections.Generic;
using food.Models;

namespace food.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}