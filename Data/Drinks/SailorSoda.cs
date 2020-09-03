/*
* Author: Matthew Sinclair
* Class name: SailorSoda.cs
* Purpose: Creates a soda and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Gets and sets the Size of the drink
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Gets the Price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.42;
                if (size == Size.Medium) return 1.74;
                if (size == Size.Large) return 2.07;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the Calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 117;
                if (size == Size.Medium) return 153;
                if (size == Size.Large) return 205;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Gets and sets the ice property
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the flavor of the drink
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Hold ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print drink
        /// </summary>
        /// <returns>string of drink name</returns>
        public override string ToString()
        {
            return size.ToString() +" " + flavor.ToString() + " Sailor Soda";
        }
    }
}
