using System.ComponentModel.DataAnnotations;
using food.Models;

namespace food.ViewModels
{
    /**/
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}