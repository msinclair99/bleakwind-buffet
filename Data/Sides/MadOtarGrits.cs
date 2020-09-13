/*
* Author: Matthew Sinclair
* Class name: MadOtarGrits.cs
* Purpose: Creates a cheesy grits and the qualities it has
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// A class which represents a side of grits
	/// </summary>
	/// <remarks>
	/// side keeps track of price, calories
	/// special instructions are blank and printing item with size info.
	/// </remarks>
	public class MadOtarGrits : Side
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
				if (size == Size.Small) return 1.22;
				if (size == Size.Medium) return 1.58;
				if (size == Size.Large) return 1.93;
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
				if (size == Size.Small) return 105;
				if (size == Size.Medium) return 142;
				if (size == Size.Large) return 179;
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
			return size.ToString() + " Mad Otar Grits";
		}
	}
}
