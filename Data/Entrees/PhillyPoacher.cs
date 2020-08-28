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
    class PhillyPoacher
    {
        /// <summary>
        /// Gets the Price of the entree
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the Calories of the entree
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets and sets the sirloin property
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets and sets the onion property
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets and sets the roll property
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
        public List<string> SpecialInstructions
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
