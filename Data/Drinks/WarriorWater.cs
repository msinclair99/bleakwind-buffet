/*
* Author: Matthew Sinclair
* Class name: WarriorWater.cs
* Purpose: Creates a water and the items it contains
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// A class which represents a water drink
	/// </summary>
	/// <remarks>
	/// drink keeps track of ice,lemon, price, calories
	/// special instructions and printing item.
	/// </remarks>
    public class WarriorWater : Drink
    {
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
				if (size == Size.Small) return 0;
				if (size == Size.Medium) return 0;
				if (size == Size.Large) return 0;
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
				if (size == Size.Small) return 0;
				if (size == Size.Medium) return 0;
				if (size == Size.Large) return 0;
				throw new NotImplementedException();
			}
		}

		/// <value>
		/// Gets and sets the ice property
		/// </value>
		public bool Ice { get; set; } = true;

		/// <value>
		/// Gets and sets the lemon property
		/// </value>
		public bool Lemon { get; set; } = false;

		/// <value>
		/// List that hold special instructions for making the drink given ice and lemon
		/// </value>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> specialInstructions = new List<string>();
				if (!Ice) specialInstructions.Add("Hold ice");
				if (Lemon) specialInstructions.Add("Add lemon");
				return specialInstructions;
			}
		}

		/// <summary>
		/// Overides the to string method to print drink
		/// </summary>
		/// <returns>string of drink name</returns>
		public override string ToString()
		{
			return size.ToString() + " Warrior Water";
		}
	}
}
