/*
* Author: Matthew Sinclair
* Interface name: IOrderItem.cs
* Purpose: Creates an interface for items that can be ordered
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for all orderable items
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        object Display { get; set; }

        /// <summary>
        /// description of the item
        /// </summary>
        string Description { get; }

        string Category { get; }

        bool newItem { get; set; }

        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
