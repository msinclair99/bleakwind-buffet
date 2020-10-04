/*
* Author: Matthew Sinclair
* Class name: SailorSoda.cs
* Purpose: Creates a soda and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
	/// A class which represents a soda drink
	/// </summary>
	/// <remarks>
	/// drink keeps track of ice,flavor, price, calories
	/// special instructions and printing item.
	/// </remarks>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// An event to be invoked on the change of a property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets and sets the Size of the drink
        /// </summary>
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
                if (size == Size.Small) return 1.42;
                if (size == Size.Medium) return 1.74;
                if (size == Size.Large) return 2.07;
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
                if (size == Size.Small) return 117;
                if (size == Size.Medium) return 153;
                if (size == Size.Large) return 205;
                throw new NotImplementedException();
            }
        }


        /// <value>
        /// Gets and sets the ice property
        /// </value>
        private bool ice = true;
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
        /// Gets and sets the flavor of the drink
        /// </value>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <value>
        /// List that hold special instructions for making the drink without ice
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Hold ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overides the to string method to print drink
        /// </summary>
        /// <returns>string of drink name</returns>
        public override string ToString()
        {
            return size.ToString() +" " + flavor.ToString() + " Sailor Soda";
        }
    }
}
