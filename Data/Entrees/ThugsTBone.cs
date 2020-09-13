/*
* Author: Matthew Sinclair
* Class name: ThugsTBone.cs
* Purpose: Creates a steak and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a steak entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class ThugsTBone : Entree
    {
        /// <value>
        /// Gets the Price of the entree
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// Gets the Calories of the entree
        /// </value>
        public override uint Calories => 982;

        /// <value>
        /// List that hold special instructions for making the entree without certain properties blank for this entree
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
