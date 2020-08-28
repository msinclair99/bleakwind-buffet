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
    class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the Price of the entree
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the Calories of the entree
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Gets and sets the sausagelink property
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets and sets the egg property
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets and sets the hashBrowns property
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Gets and sets the pancake property
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
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
