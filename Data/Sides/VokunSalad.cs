/*
* Author: Matthew Sinclair
* Class name: VokunSalad.cs
* Purpose: Creates a salad and the qualities it has
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// A class which represents a side salad
	/// </summary>
	/// <remarks>
	/// side keeps track of price, calories
	/// special instructions are blank and printing item with size info.
	/// </remarks>
	public class VokunSalad
    {
		/// <value>
		/// Gets and sets the Size of the side
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
		/// Gets the Price of the side
		/// </value>
		/// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
		public double Price
		{
			get
			{
				if (size == Size.Small) return .93;
				if (size == Size.Medium) return 1.28;
				if (size == Size.Large) return 1.82;
				throw new NotImplementedException();
			}
		}

		/// <value>
		/// Gets the Calories of the side
		/// </value>
		/// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
		public uint Calories
		{
			get
			{
				if (size == Size.Small) return 41;
				if (size == Size.Medium) return 52;
				if (size == Size.Large) return 73;
				throw new NotImplementedException();
			}
		}

		/// <value>
		/// List that hold special instructions for making the side set blank
		/// </value>
		public List<string> SpecialInstructions
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
			return size.ToString() + " Vokun Salad";
		}
	}
}
