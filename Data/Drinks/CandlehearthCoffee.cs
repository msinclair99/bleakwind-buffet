/*
* Author: Matthew Sinclair
* Class name: CandlehearthCoffee.cs
* Purpose: Creates a coffee and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
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
	public class CandlehearthCoffee
    {
		/// <value>
		/// Gets and sets the Size of the drink
		/// </value>
		private Size size = Size.Small;
		public Size Size
		{
			get
			{
				return size;
			}
			set
			{
				size = value;
			}
		}

		/// <value>
		/// Gets the Price of the drink
		/// </value>
		/// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
		public double Price
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
		public uint Calories
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
		public bool Ice { get; set; } = false;

		/// <value>
		/// Gets and sets the cream property
		/// </value>
		public bool RoomForCream { get; set; } = false;

		/// <value>
		/// Gets and sets the decaf property
		/// </value>
		public bool Decaf { get; set; } = false;

		/// <value>
		/// List that hold special instructions for making the drink with ice or cream
		/// </value>
		public List<string> SpecialInstructions
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
