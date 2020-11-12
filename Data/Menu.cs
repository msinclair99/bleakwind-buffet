/*
* Author: Matthew Sinclair
* Class name: Menu.cs
* Purpose: Creates a menu colletion which contains all the items available
*/
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// static menu which contains collections for available items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets an instance of all entrees
        /// </summary>
        /// <returns>Collection of all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();
            yield break;
        }

        /// <summary>
        /// Gets an instance of all sides
        /// </summary>
        /// <returns>Collection of all sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = size;
                yield return dwf;

                FriedMiraak fm = new FriedMiraak();
                fm.Size = size;
                yield return fm;

                MadOtarGrits mog = new MadOtarGrits();
                mog.Size = size;
                yield return mog;

                VokunSalad vs = new VokunSalad();
                vs.Size = size;
                yield return vs;

            }
            yield break;
        }

        /// <summary>
        /// Gets an instance of all drinks
        /// </summary>
        /// <returns>Collection of all sides</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = size;
                yield return aj;

                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = size;
                yield return cc;

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = size;
                yield return mm;

                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Flavor = flavor;
                    ss.Size = size;
                    yield return ss;
                }

                WarriorWater ww = new WarriorWater();
                ww.Size = size;
                yield return ww;
            }

            yield break;
              
        }

        /// <summary>
        /// Gets an instance of all Entrees, sides, and drinks
        /// </summary>
        /// <returns>Collection of all Entrees, sides, and drinks</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> drink = new List<IOrderItem>(Drinks());
            List<IOrderItem> side = new List<IOrderItem>(Sides());
            List<IOrderItem> entree = new List<IOrderItem>(Entrees());
            foreach (var orderitem in entree)
            {
                yield return orderitem;
            }

            foreach (var orderitem in side)
            {
                yield return orderitem;
            }

            foreach (var orderitem in drink)
            {
                yield return orderitem;
            }
        }

        /// <summary>
        /// list of items with given term in them
        /// </summary>
        /// <param name="items">list of items</param>
        /// <param name="term">search word</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (term == null)
            {
                return FullMenu();
            }

            foreach (IOrderItem item in items)
            {
                             
                //add the menu item if the name is a match
                if (item.ToString() != null && (item.ToString().ToLower().Contains(term.ToLower())))// || item.about.Contains(term.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters the list given catagory of menu item
        /// </summary>
        /// <param name="items">item list</param>
        /// <param name="type">catagory of menu item we want</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> type)
        {

            // If no filter is specified, just return the provided collection
            if (type == null || type.Count() == 0) return items;

            // Filter the supplied collection of menu items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (string category in type)
            {
                foreach (IOrderItem item in items)
                {
                    if (category=="Entree" && item != null && item is Entree )
                    {
                        results.Add(item);
                    }
                    if (category == "Side" && item != null && item is Side)
                    {
                        results.Add(item);
                    }
                    if (category == "Drink" && item != null && item is Drink)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list with calories windows
        /// </summary>
        /// <param name="items">list of menu items</param>
        /// <param name="min">lower bound</param>
        /// <param name="max">upper bound</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list with price windows
        /// </summary>
        /// <param name="items">list of menu items</param>
        /// <param name="min">lower bound price</param>
        /// <param name="max">upper bound price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max )
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
    
}
