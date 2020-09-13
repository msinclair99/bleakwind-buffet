/*
* Author: Matthew Sinclair
* Class name: DragonbornWaffleFries.cs
* Purpose: Creates fries and the qualities it has
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// A class which represents a side of waffle fies
	/// </summary>
	/// <remarks>
	/// side keeps track of price, calories
	/// special instructions are blank and printing item with size info.
	/// </remarks>
	public class DragonbornWaffleFries : Side
    {
		/// <value>
		/// Gets and sets the Size of the side
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
		/// Gets the Price of the side
		/// </value>
		/// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
		public override double Price
		{
			get
			{
				if (size == Size.Small) return 0.42;
				if (size == Size.Medium) return 0.76;
				if (size == Size.Large) return 0.96;
				throw new NotImplementedException();
			}
		}

		/// <value>
		/// Gets the Calories of the side
		/// </value>
		/// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
		public override uint Calories
		{
			get
			{
				if (size == Size.Small) return 77;
				if (size == Size.Medium) return 89;
				if (size == Size.Large) return 100;
				throw new NotImplementedException();
			}
		}

		/// <value>
		/// List that hold special instructions for making the side set blank
		/// </value>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> specialInstructions = new List<string>();
				return specialInstructions;
			}
		}

		/// <summary>
		/// Overides the to string method to print side
		/// </summary>
		/// <returns>string of side name</returns>
		public override string ToString()
		{
			return size.ToString() + " Dragonborn Waffle Fries";
		}
	}
}
