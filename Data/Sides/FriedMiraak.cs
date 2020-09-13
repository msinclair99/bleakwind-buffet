/*
* Author: Matthew Sinclair
* Class name: FriedMiraak.cs
* Purpose: Creates a hash brown pancakes and the qualities it has
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// A class which represents a side of hash brown pancakes
	/// </summary>
	/// <remarks>
	/// side keeps track of price, calories
	/// special instructions are blank and printing item with size info.
	/// </remarks>
	public class FriedMiraak : Side
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
				if (size == Size.Small) return 1.78;
				if (size == Size.Medium) return 2.01;
				if (size == Size.Large) return 2.88;
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
				if (size == Size.Small) return 151;
				if (size == Size.Medium) return 236;
				if (size == Size.Large) return 306;
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
			return size.ToString() + " Fried Miraak";
		}
	}
}
