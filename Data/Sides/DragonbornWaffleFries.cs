﻿/*
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
    public class DragonbornWaffleFries
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
				if (size == Size.Small) return 0.42;
				if (size == Size.Medium) return 0.76;
				if (size == Size.Large) return 0.96;
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
				if (size == Size.Small) return 77;
				if (size == Size.Medium) return 89;
				if (size == Size.Large) return 100;
				throw new NotImplementedException();
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