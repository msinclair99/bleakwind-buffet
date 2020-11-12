/*
* Author: Matthew Sinclair
* Class name: AretinoAppleJuice.cs
* Purpose: Creates a apple juice and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
   
    /// <summary>
	/// A class which represents a apple drink
	/// </summary>
	/// <remarks>
	/// drink keeps track of ice, price, calories
	/// special instructions and printing item.
	/// </remarks>
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// An event to be invoked on the change of a property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// description of the item
        /// </summary>
        public override string Description { get { return "Fresh squeezed apple juice."; } }

        public bool newItem { get; set; } = true;

        /// <value>
        /// Gets and sets the Size of the drink
        /// </value>
        private Size size = Size.Small;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <value>
        /// Gets the Price of the drink
        /// </value>
        /// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                throw new NotImplementedException();
            }
        }

        /// <value>
        /// Gets the Calories of the drink
        /// </value>
        /// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                throw new NotImplementedException();
            }
        }

        /// <value>
        /// Gets and sets the ice property
        /// </value>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }

        /// <value>
        /// List that hold special instructions for making the drink with ice
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) specialInstructions.Add("Add ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print drink
        /// </summary>
        /// <returns>string of drink name</returns>
        public override string ToString()
        {
            return size.ToString()+ " Aretino Apple Juice";
        }
    }
}
