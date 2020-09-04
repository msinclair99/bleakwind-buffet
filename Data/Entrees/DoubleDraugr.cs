/*
* Author: Matthew Sinclair
* Class name: DoubleDraugr.cs
* Purpose: Creates a double draugr burger and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a double burger entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class DoubleDraugr
    {
        /// <value>
        /// Gets the Price of the Burger
        /// </value>
        public double Price => 7.32;

        /// <value>
        /// Gets the Calories of the Burger
        /// </value>
        public uint Calories => 843;

        /// <value>
        /// Gets and sets the bun property
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Gets and sets the ketchup property
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Gets and sets the mustard property
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Gets and sets the pickle property
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Gets and sets the cheese property
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// Gets and sets the tomato property
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Gets and sets the lettuce property
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Gets and sets the Mayo property
        /// </value>
        public bool Mayo { get; set; } = true;

        /// <value>
        /// List that hold special instructions for making the entree without certain properties
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun) specialInstructions.Add("Hold bun");
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Lettuce) specialInstructions.Add("Hold lettuce");
                if (!Mayo) specialInstructions.Add("Hold mayo");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
