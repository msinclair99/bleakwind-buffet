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
    class FriedMiraak
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
				if (size == Size.Small) return 1.78;
				if (size == Size.Medium) return 2.01;
				if (size == Size.Large) return 2.88;
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
				if (size == Size.Small) return 151;
				if (size == Size.Medium) return 236;
				if (size == Size.Large) return 306;
				throw new NotImplementedException();
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
