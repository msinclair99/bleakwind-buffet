﻿/*
* Author: Matthew Sinclair
* Class name: VokunSalad.cs
* Purpose: Creates a salad and the qualities it has
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public class VokunSalad : Side, INotifyPropertyChanged
	{
		/// <summary>
		/// An event to be invoked on the change of a property
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		// <summary>
		/// description of the item
		/// </summary>
		public override string Description { get { return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; } }

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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
		public override uint Calories
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
			return size.ToString() + " Vokun Salad";
		}
	}
}
