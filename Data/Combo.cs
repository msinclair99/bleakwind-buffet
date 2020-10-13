/*
 * Author: Matthew Sinclair
 * Class: Combo.cs
 * Purpose: Creates a combo for use to combine drink, side and entree
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event to be invoked on the change of a property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public object Display { get; set; }
        public bool newItem { get; set; } = true;

        private Side comboSide;
        public Side ComboSide
        {
            get { return comboSide; }
            set
            {
                comboSide.PropertyChanged -= ComboChangedListener;
                comboSide = value;
                comboSide.PropertyChanged += ComboChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboSide"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                
            }
        }

        private Drink comboDrink;
        public Drink ComboDrink
        {
            get { return comboDrink; }
            set
            {
                comboDrink.PropertyChanged -= ComboChangedListener;
                comboDrink = value;
                comboDrink.PropertyChanged += ComboChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboDrink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                
            }
        }

        private Entree comboEntree;
        public Entree ComboEntree
        {
            get { return comboEntree; }
            set
            {
                comboEntree.PropertyChanged -= ComboChangedListener;
                comboEntree = value;
                comboEntree.PropertyChanged += ComboChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboEntree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                
            }
        }

        /// <value>
        /// Gets the Price of the drink
        /// </value>
        /// 
        public double Price
        {
            get
            {
                return ((comboDrink.Price + comboEntree.Price + comboSide.Price)-1);
            }
        }

        /// <value>
        /// Gets the total Calories of the combo
        /// </value>
        /// <exception cref="System.NotImplementedException">Thrown if the size is not set to one of the three options</exception>
        public uint Calories
        {
            get
            {
                return (comboDrink.Calories + comboEntree.Calories + comboSide.Calories);
            }
        }


        /// <value>
        /// List that hold special instructions for making the drink with ice
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                specialInstructions.Add(comboEntree.ToString());
                foreach (string si in comboEntree.SpecialInstructions)
                {
                    specialInstructions.Add(si);
                }
                specialInstructions.Add(comboSide.ToString());
                foreach (string si in comboSide.SpecialInstructions)
                {
                    specialInstructions.Add(si);
                }
                specialInstructions.Add(comboDrink.ToString());
                foreach (string si in comboDrink.SpecialInstructions)
                {
                    specialInstructions.Add(si);
                }
                return specialInstructions;
            }
        }

        /// <summary>
        /// adds listensers for when items is changed in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ComboChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                
            }
            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }
    }
}
