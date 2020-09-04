/*
* Author: Matthew Sinclair
* Class name: AretinoAppleJuice.cs
* Purpose: Creates a apple juice and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
	/// A class which represents a apple drink
	/// </summary>
	/// <remarks>
	/// drink keeps track of ice, price, calories
	/// special instructions and printing item.
	/// </remarks>
    public class AretinoAppleJuice
    {
        /// <value>
        /// Gets and sets the Size of the drink
        /// </value>
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

        /// <value>
        /// Gets the Price of the drink
        /// </value>
        /// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                throw new NotImplementedException();
            }
        }

        /// <value>
        /// Gets the Calories of the drink
        /// </value>
        /// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                throw new NotImplementedException();
            }
        }

        /// <value>
        /// Gets and sets the ice property
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// List that hold special instructions for making the drink with ice
        /// </value>
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
            return size.ToString()+ " Aretino Apple Juice";
        }
    }
}
