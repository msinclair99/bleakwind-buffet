/*
 * Author: Matthew Sinclair
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using static BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using System.Linq;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests the Menu class in the Data library
    /// </summary>
    public class menutests
    {

        [Fact]
        public void EntreesCount()
        {
            Assert.Equal(7, Entrees().Count());
        }

        [Fact]
        public void AllEntreesReturned()
        {
            Assert.Collection<IOrderItem>(Entrees(),
                (bb) => { Assert.IsType<BriarheartBurger>(bb); },
                (dd) => { Assert.IsType<DoubleDraugr>(dd); },
                (goo) => { Assert.IsType<GardenOrcOmelette>(goo); },
                (pp) => { Assert.IsType<PhillyPoacher>(pp); },
                (ss) => { Assert.IsType<SmokehouseSkeleton>(ss); },
                (ttr) => { Assert.IsType<ThalmorTriple>(ttr); },
                (ttb) => { Assert.IsType<ThugsTBone>(ttb); }
                );
       }

        [Fact]
        public void SidesCount()
        {
            Assert.Equal(12, Sides().Count());
        }

        [Fact]
        public void AllSidesReturned()
        {
            Assert.Collection<IOrderItem>(Sides(),
                (dwf) =>  Assert.Equal("Small Dragonborn Waffle Fries", dwf.ToString()),
                (fm) => Assert.Equal("Small Fried Miraak", fm.ToString()),
                (mog) => Assert.Equal("Small Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Small Vokun Salad", vs.ToString()),

                (dwf) =>  Assert.Equal("Medium Dragonborn Waffle Fries", dwf.ToString()),
                (fm) => Assert.Equal("Medium Fried Miraak", fm.ToString()),
                (mog) => Assert.Equal("Medium Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Medium Vokun Salad", vs.ToString()),

                (dwf) =>  Assert.Equal("Large Dragonborn Waffle Fries", dwf.ToString()),              
                (fm) => Assert.Equal("Large Fried Miraak", fm.ToString()),               
                (mog) => Assert.Equal("Large Mad Otar Grits", mog.ToString()),
                (vs) => Assert.Equal("Large Vokun Salad", vs.ToString())
                );
        }

        [Fact]
        public void DrinksCount()
        {
            Assert.Equal(30, Drinks().Count());
        }

        [Fact]
        public void AllDrinksReturned()
        {
            Assert.Collection<IOrderItem>(Drinks(),
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
        [Fact]
        public void FullMenuCount()
        {
            Assert.Equal(49, FullMenu().Count());
        }

        [Fact]
        public void AllFullMenuReturned()
        {
            Assert.Collection<IOrderItem>(FullMenu(),
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
