/*
* Author: Matthew Sinclair
* Class name: CandlehearthCoffee.cs
* Purpose: Creates a coffee and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{

	/// <summary>
	/// A class which represents a coffee drink
	/// </summary>
	/// <remarks>
	/// drink keeps track of ice, cream, decaf, price, calories
	/// special instructions and printing item.
	/// </remarks>
	public class CandlehearthCoffee : Drink, INotifyPropertyChanged
	{

		/// <summary>
		/// An event to be invoked on the change of a property
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// description of the item
		/// </summary>
		public override string Description { get { return "Fair trade, fresh ground dark roast coffee."; } }

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
				if (size == Size.Small) return 0.75;
				if (size == Size.Medium) return 1.25;
				if (size == Size.Large) return 1.75;
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
				if (size == Size.Small) return 7;
				if (size == Size.Medium) return 10;
				if (size == Size.Large) return 20;
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
		/// Gets and sets the cream property
		/// </value>
		private bool roomforcream = false;
		public bool RoomForCream
		{
			get { return roomforcream; }
			set
			{
				roomforcream = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
			}
		}

		/// <value>
		/// Gets and sets the decaf property
		/// </value>
		private bool decaf = false;
		public bool Decaf
		{
			get { return decaf; }
			set
			{
				decaf = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
			}
		}

		/// <value>
		/// List that hold special instructions for making the drink with ice or cream
		/// </value>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> specialInstructions = new List<string>();
				if (Ice) specialInstructions.Add("Add ice");
				if (RoomForCream) specialInstructions.Add("Add cream");
				return specialInstructions;
			}
		}

		/// <summary>
		/// Overides the to string method to print drink
		/// </summary>
		/// <returns>string of drink name</returns>
		public override string ToString()
		{	
			string decaf = "";
			if (Decaf) decaf = " Decaf";
			return size.ToString() + decaf +" Candlehearth Coffee";
		}

	}
}
