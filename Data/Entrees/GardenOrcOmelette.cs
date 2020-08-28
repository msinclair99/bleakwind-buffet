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
    class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the Price of the entree
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the Calories of the entree
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Gets and sets the broccoli property
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets and sets the mushrooms property
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets and sets the tomato property
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets the cheddar property
        /// </summary>
        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
        public List<string> SpecialInstructions
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
