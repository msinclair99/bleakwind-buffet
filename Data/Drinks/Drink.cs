﻿/*
* Author: Matthew Sinclair
* Class name: Drink.cs
* Purpose: Creates an abstract class for drink properties
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// description of the item
        /// </summary>
        public abstract string Description { get; }

        public virtual string Category => "Drink";

        public object Display { get; set; }
        public bool newItem { get; set; } = true;
        /// <summary>
        /// binds Name to the ToString of an item
        /// </summary>
        public virtual string Name => ToString();

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


    }
}
