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
    class MadOtarGrits
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
				if (size == Size.Small) return 1.22;
				if (size == Size.Medium) return 1.58;
				if (size == Size.Large) return 1.93;
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
				if (size == Size.Small) return 105;
				if (size == Size.Medium) return 142;
				if (size == Size.Large) return 179;
				throw new NotImplementedException();
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
