/*
* Author: Matthew Sinclair
* Class name: ThalmorTriple.cs
* Purpose: Creates a thalmor triple burger and the items that such has
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        /// <summary>
        /// Gets the Price of the Burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the Calories of the Burger
        /// </summary>
        public uint Calories => 943;

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
        /// Gets and sets the bacon property
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets and sets the egg property
        /// </summary>
        public bool Egg { get; set; } = true;

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
                if (!Bacon) specialInstructions.Add("Hold bacon");
                if (!Egg) specialInstructions.Add("Hold egg");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print entree name
        /// </summary>
        /// <returns>string of entree name</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
