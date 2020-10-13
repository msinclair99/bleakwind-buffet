/*
 * Author: Matthew Sinclair
 * Class: Order.cs
 * Purpose: Creates a collection for an order
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order :  ObservableCollection<IOrderItem>
    {

        public Order(uint i)
        {
            CollectionChanged += CollectionChangedListener;
            orderNumber = i;
        }

        private uint orderNumber = 0;
        public uint OrderNumber
        {
            get
            {
                return orderNumber;
            }
        }

        public double SalesTaxRate { get; set; } = .12;

        private double subtotal = 0;
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        public double Tax
        {
            get
            {
                return subtotal * SalesTaxRate;
            }
        }

        public double Total
        {
            get
            {
                return subtotal + Tax;
            }
        }

        private uint calories = 0;
        public uint Calories
        {
            get
            {
                calories = 0;
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }


/// <summary>
/// Adds listeners when collections changes and add items listeners when collection changes
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
public void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem items in e.OldItems)
                    {
                        items.PropertyChanged -= CollectionItemChangedListner;
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    foreach (IOrderItem item in this)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                        OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    }
                    break;
            }
        }

        /// <summary>
        /// adds listensers for when items is changed in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CollectionItemChangedListner(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SpecialInstructions")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));

            }
            if (e.PropertyName == "Size")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                OnPropertyChanged(new PropertyChangedEventArgs("Size"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                
            }

        }

    }
}
