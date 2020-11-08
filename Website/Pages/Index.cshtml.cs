/*
* Author: Matthew Sinclair
* Class name: Index.cshtml.cs
* Purpose: Creates an index page that display the menu and welcome message along with filterability with the menu
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Security.Cryptography.Xml;

namespace Website.Pages
{
    /// <summary>
    /// Index page for the menu
    /// </summary>
    public class IndexModel : PageModel
    {
        public List<string> itemTypes = new List<string> { "Entree", "Drink", "Side" };
        
        /// <summary>
        /// Used to hold the filter paramters for them to remain shown after seaches 
        /// </summary>
        public string[] itemInclude { get; set; }
        public string searchTerms { get; set; }
        public uint? caloriesMin { get; set; }
        public uint? caloriesMax { get; set; }
        public double? priceMin { get; set; }
        public double? priceMax { get; set; }

        /// <summary>
        /// filtered list
        /// </summary>
        public IEnumerable<IOrderItem> MenuList { get; set; }

        /// <summary>
        /// keeps track of items that are already shown
        /// </summary>
        public List<string> used = new List<string>();
        public int counts { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] MenuItems, double? PriceMin, double? PriceMax, uint? CaloriesMin, uint? CaloriesMax)
        {
            itemInclude = MenuItems; searchTerms = SearchTerms; priceMin = PriceMin; priceMax = PriceMax; caloriesMin = CaloriesMin; caloriesMax = CaloriesMax;
            MenuList = Menu.Search(Menu.FullMenu(), SearchTerms);
            MenuList = Menu.FilterByCategory(MenuList, MenuItems);
            MenuList = Menu.FilterByPrice(MenuList, PriceMin, PriceMax);
            MenuList = Menu.FilterByCalories (MenuList, CaloriesMin, CaloriesMax);
        }

        /// <summary>
        /// Find similair items object from the filtered menu list to display sizes correctly
        /// </summary>
        /// <param name="orderItems">list of filtered menu items</param>
        /// <param name="x">item to find similiar one of</param>
        /// <returns>List of items which are the similiar</returns>
        public List<IOrderItem> ListExtractor(IEnumerable<IOrderItem> orderItems, IOrderItem x)
        {
            string finder = x.GetType().Name;

            List<IOrderItem> sameItems = new List<IOrderItem>();

            foreach(IOrderItem item in orderItems)
            {
                if(finder == item.GetType().Name)
                {
                    sameItems.Add(item);
                }
            }
            used.Add(finder);
            return sameItems;
        }

    }
}
