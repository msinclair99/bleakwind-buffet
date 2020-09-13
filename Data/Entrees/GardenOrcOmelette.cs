/*
* Author: Matthew Sinclair
* Class name: GardenOrcOmelette.cs
* Purpose: Creates an omelette and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a omelette entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class GardenOrcOmelette : Entree
    {
        /// <value>
        /// Gets the Price of the entree
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// Gets the Calories of the entree
        /// </value>
        public override uint Calories => 404;

        /// <value>
        /// Gets and sets the broccoli property
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// Gets and sets the mushrooms property
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// Gets and sets the tomato property
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Gets and sets the cheddar property
        /// </value>
        public bool Cheddar { get; set; } = true;


        /// <value>
        /// List that hold special instructions for making the entree without certain properties
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
