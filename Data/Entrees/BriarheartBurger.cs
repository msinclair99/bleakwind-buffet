/*
* Author: Matthew Sinclair
* Class name: BriarheartBurger.cs
* Purpose: Creates a briarheart burger and the items that such has
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a single burger entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class BriarheartBurger : Entree
    {
        /// <value>
        /// Gets the Price of the Burger
        /// </value>
        public override double Price => 6.32;

        /// <value>
        /// Gets the Calories of the Burger
        /// </value>
        public override uint Calories => 743;

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
        /// List that hold special instructions for making the entree without certain properties
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun) specialInstructions.Add("Hold bun");
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }

}
