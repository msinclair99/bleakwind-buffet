/*
* Author: Matthew Sinclair
* Class name: MarkarthMilk.cs
* Purpose: Creates a milk and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
                if (size == Size.Small) return 1.05;
                if (size == Size.Medium) return 1.11;
                if (size == Size.Large) return 1.22;
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
                if (size == Size.Small) return 56;
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Gets and sets the ice property
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) specialInstructions.Add("Add ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print drink
        /// </summary>
        /// <returns>string of drink name</returns>
        public override string ToString()
        {
            return size.ToString() + " Markarth Milk";
        }
    }
}
