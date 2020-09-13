/*
* Author: Matthew Sinclair
* Class name: PhillyPoacher.cs
* Purpose: Creates a philly cheesteak sandwich and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a cheesesteak sandwhich entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class PhillyPoacher : Entree
    {
        /// <value>
        /// Gets the Price of the entree
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// Gets the Calories of the entree
        /// </value>
        public override uint Calories => 784;

        /// <value>
        /// Gets and sets the sirloin property
        /// </value>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// Gets and sets the onion property
        /// </value>
        public bool Onion { get; set; } = true;

        /// <value>
        /// Gets and sets the roll property
        /// </value>
        public bool Roll { get; set; } = true;

        /// <value>
        /// List that hold special instructions for making the entree without certain properties
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onions");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
