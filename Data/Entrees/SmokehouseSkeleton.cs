/*
* Author: Matthew Sinclair
* Class name: SmokehouseSkeleton.cs
* Purpose: Creates a breakfast combo and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
	/// A class which represents a breakfast combo entree
	/// </summary>
	/// <remarks>
	/// entree keeps track of holding components, price, calories
	/// special instructions for holding items and printing item.
	/// </remarks>
    public class SmokehouseSkeleton
    {
        /// <value>
        /// Gets the Price of the entree
        /// </value>
        public double Price => 5.62;

        /// <value>
        /// Gets the Calories of the entree
        /// </value>
        public uint Calories => 602;

        /// <value>
        /// Gets and sets the sausagelink property
        /// </value>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// Gets and sets the egg property
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// Gets and sets the hashBrowns property
        /// </value>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// Gets and sets the pancake property
        /// </value>
        public bool Pancake { get; set; } = true;

        /// <value>
        /// List that hold special instructions for making the entree without certain properties
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!SausageLink) specialInstructions.Add("Hold sausage");
                if (!Egg) specialInstructions.Add("Hold eggs");
                if (!HashBrowns) specialInstructions.Add("Hold hash browns");
                if (!Pancake) specialInstructions.Add("Hold pancakes");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
