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
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the Price of the entree
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets the Calories of the entree
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
        public List<string> SpecialInstructions
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
