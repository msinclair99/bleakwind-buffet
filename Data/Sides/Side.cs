/*
* Author: Matthew Sinclair
* Class name: Entree.cs
* Purpose: Creates an abstract class for side properties
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{

    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public object Display { get; set; }
        public bool newItem { get; set; } = true;

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// binds Name to the ToString of an item
        /// </summary>
        public virtual string Name => ToString();

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
