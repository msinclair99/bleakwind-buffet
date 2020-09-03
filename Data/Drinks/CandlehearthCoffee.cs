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
    public class CandlehearthCoffee
    {
		/// <summary>
		/// Gets and sets the Size of the drink
		/// </summary>
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

		/// <summary>
		/// Gets the Price of the drink
		/// </summary>
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

		/// <summary>
		/// Gets the Calories of the drink
		/// </summary>
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

		/// <summary>
		/// Gets and sets the ice property
		/// </summary>
		public bool Ice { get; set; } = false;

		/// <summary>
		/// Gets and sets the cream property
		/// </summary>
		public bool RoomForCream { get; set; } = false;

		/// <summary>
		/// Gets and sets the decaf property
		/// </summary>
		public bool Decaf { get; set; } = false;

		/// <summary>
		/// List that hold special instructions for making the entree without certain properties
		/// </summary>
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
