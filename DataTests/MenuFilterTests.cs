using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    /// <summary>
    /// tests the filter features for terms, catoagory of menu item, calorie and price ranges
    /// </summary>
    public class MenuFilterTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("Pl")]
        [InlineData("th")]
        [InlineData(null)]
        public void SearchShouldFilterTerms(string terms)
        {
            IEnumerable<IOrderItem> itemList = Menu.FullMenu();
            itemList = Menu.Search(itemList, terms);
            if (terms == null || terms.Equals(""))
            {
                Assert.Collection(
                itemList,
                (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                (ttb) => { Assert.IsType<ThugsTBone>(ttb); },
                (dwf) => Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                (dwf) => Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                (dwf) => Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),
                (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Large Vokun Salad", vs.ToString()),

                (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                (ss) => Assert.Equal("Small Blackberry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Small Cherry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Small Grapefruit Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Small Lemon Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Small Peach Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Small Watermelon Sailor Soda", ss.ToString()),
                (ww) => Assert.Equal("Small Warrior Water", ww.ToString()),

                (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                (ss) => Assert.Equal("Medium Blackberry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Medium Cherry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Medium Grapefruit Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Medium Lemon Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Medium Peach Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Medium Watermelon Sailor Soda", ss.ToString()),
                (ww) => Assert.Equal("Medium Warrior Water", ww.ToString()),

                (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString()),
                (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Large Markarth Milk", mm.ToString()),
                (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString()),
                (ww) => Assert.Equal("Large Warrior Water", ww.ToString())
                );
            }
            else if (terms.Equals("Pl"))
            {

                Assert.Collection(
                    itemList,
                    (tt) => { Assert.IsType<ThalmorTriple>(tt); },
                    (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                    (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                    (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString())
                    );


            }
            else if (terms.Equals("th"))
            {
                Assert.Collection(
                itemList,
                (tt) => { Assert.IsType<ThalmorTriple>(tt); },
                (tb) => { Assert.IsType<ThugsTBone>(tb); },
                (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                (mm) => Assert.Equal("Large Markarth Milk", mm.ToString())
                );
            }

        }

        [Theory]
        [InlineData("Entree", "Side", "Drink")]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        [InlineData(null)]

        public void FilterByCategoryShouldFilterCategories(params string[] categories)
        {
            IEnumerable<IOrderItem> itemList = Menu.FullMenu();
            itemList = Menu.FilterByCategory(itemList, categories);

            if (categories == null || (categories.Contains("Entree") && categories.Contains("Side") && categories.Contains("Drink")))
            {
                Assert.Collection(
                 itemList,
                 (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                 (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                 (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                 (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                 (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                 (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                 (ttb) => { Assert.IsType<ThugsTBone>(ttb); },
                 (dwf) => Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                 (dwf) => Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                 (dwf) => Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Large Vokun Salad", vs.ToString()),

                 (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Small Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Small Warrior Water", ww.ToString()),

                 (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Medium Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Medium Warrior Water", ww.ToString()),

                 (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Large Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Large Warrior Water", ww.ToString())
                 );
            }
            else if (categories.Contains("Entree"))
            {
                Assert.Collection(
                itemList,
                (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                 (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                 (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                 (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                 (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                 (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                 (ttb) => { Assert.IsType<ThugsTBone>(ttb); }
                );
            }
            else if (categories.Contains("Side"))
            {
                Assert.Collection(
                itemList,
             (dwf) => Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                 (dwf) => Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                 (dwf) => Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),
                 (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                 (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                 (vs) => Assert.Equal("Large Vokun Salad", vs.ToString())
                );
            }
            else if (categories.Contains("Drink"))
            {
                Assert.Collection(
                itemList,
                (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Small Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Small Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Small Warrior Water", ww.ToString()),

                 (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Medium Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Medium Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Medium Warrior Water", ww.ToString()),

                 (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString()),
                 (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                 (mm) => Assert.Equal("Large Markarth Milk", mm.ToString()),
                 (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                 (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString()),
                 (ww) => Assert.Equal("Large Warrior Water", ww.ToString())
                );
            }
        }

        [Theory]
        [InlineData((uint)0, (uint)1000)]
        [InlineData(null, (uint)1000)]
        [InlineData((uint)0, null)]
        [InlineData(null, null)]
        [InlineData((uint)200, (uint)300)]
        [InlineData((uint)600, (uint)700)]

        public void FilterByCaloriesShouldFilterByCalories(uint? min, uint? max)
        {
            IEnumerable<IOrderItem> itemList = Menu.FullMenu();
            itemList = Menu.FilterByCalories(itemList, min, max);

            if (min == 200)//for item over 200 calories
            {
                Assert.Collection(
                   itemList,
                     (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                     (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString())
                   );
            }
            else if (min == 600) //checks for item with 600 calories
            {
                Assert.Collection(
                    itemList,
                    (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); }
                    );
            }
            else
            {
                Assert.Collection(
                    itemList,
                     (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                     (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                     (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                     (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                     (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                     (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                     (ttb) => { Assert.IsType<ThugsTBone>(ttb); },
                     (dwf) => Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                     (dwf) => Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                     (dwf) => Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Large Vokun Salad", vs.ToString()),

                     (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Small Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Small Warrior Water", ww.ToString()),

                     (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Medium Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Medium Warrior Water", ww.ToString()),

                     (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Large Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Large Warrior Water", ww.ToString())
                    );
            }
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(null, 10)]
        [InlineData(0, null)]
        [InlineData(null, null)]
        [InlineData(2.00, 3.00)]

        public void FilterByPriceShouldFilterByPrice(double? min, double? max)
        {
            IEnumerable<IOrderItem> itemList = Menu.FullMenu();
            itemList = Menu.FilterByPrice(itemList, min, max);

            if (min == 2.00)//tests for item that has over $2.00 for medium and large 
            {
                Assert.Collection(
                    itemList,
                     (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                     (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                     (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString())
                    );
            }
            else
            {
                Assert.Collection(
                    itemList,
                    (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                     (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                     (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                     (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                     (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                     (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                     (ttb) => { Assert.IsType<ThugsTBone>(ttb); },
                     (dwf) => Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                     (dwf) => Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                     (dwf) => Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),
                     (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),
                     (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                     (vs) => Assert.Equal("Large Vokun Salad", vs.ToString()),

                     (aa) => Assert.Equal("Small Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Small Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Small Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Small Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Small Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Small Warrior Water", ww.ToString()),

                     (aa) => Assert.Equal("Medium Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Medium Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Medium Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Medium Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Medium Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Medium Warrior Water", ww.ToString()),

                     (aa) => Assert.Equal("Large Aretino Apple Juice", aa.ToString()),
                     (cc) => Assert.Equal("Large Candlehearth Coffee", cc.ToString()),
                     (mm) => Assert.Equal("Large Markarth Milk", mm.ToString()),
                     (ss) => Assert.Equal("Large Blackberry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Cherry Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Grapefruit Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Lemon Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Peach Sailor Soda", ss.ToString()),
                     (ss) => Assert.Equal("Large Watermelon Sailor Soda", ss.ToString()),
                     (ww) => Assert.Equal("Large Warrior Water", ww.ToString())
                    );
            }

        }

    }
}
