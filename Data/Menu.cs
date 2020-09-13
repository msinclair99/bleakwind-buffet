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
    }
}
