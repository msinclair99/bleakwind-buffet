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
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the Price of the Burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the Calories of the Burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Gets and sets the bun property
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets and sets the ketchup property
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets and sets the mustard property
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets and sets the pickle property
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets and sets the cheese property
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets and sets the tomato property
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets the lettuce property
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets and sets the Mayo property
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// List that hold special instructions for making the entree without certain properties
        /// </summary>
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
