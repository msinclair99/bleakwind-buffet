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
    public class VokunSalad
    {
		/// <summary>
		/// Gets and sets the Size of the side
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
		/// Gets the Price of the side
		/// </summary>
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

		/// <summary>
		/// Gets the Calories of the side
		/// </summary>
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
