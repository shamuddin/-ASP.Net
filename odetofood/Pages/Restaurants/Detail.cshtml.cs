using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace odetofood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private IRestaurantData restaurantData;

        public Restaurant Restaurant { get; set; }
        public IRestaurantData RestaurantData { get; }

        [TempData]
        public string Message { get; set; }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId); //page is going to bind restaurantData.GetById
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page(); //Page() Helper Method
            //saying .net to render the requested page
        }

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

    }
}
