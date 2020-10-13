/*
* Author: Matthew Sinclair
* Class name: Entree.cs
* Purpose: Creates an abstract class for entree properties
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
   
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public object Display { get; set; }
        public bool newItem { get; set; } = true;
        /// <summary>
        /// binds Name to the ToString of an item
        /// </summary>
        public virtual string Name => ToString();

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
