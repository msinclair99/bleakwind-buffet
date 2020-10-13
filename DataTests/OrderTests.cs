/*
 * Author: Matthew Sinclair
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ImplementsComponents()
        {
            Order o = new Order(1);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(o);
        }

        [Fact]
        public void AddingItemUpdates()
        {
            Order o = new Order(1);
            Assert.PropertyChanged(o, "Subtotal", () => { o.Add(new AretinoAppleJuice()); });
            Assert.PropertyChanged(o, "Tax", () => { o.Add(new AretinoAppleJuice()); });
            Assert.PropertyChanged(o, "Total", () => { o.Add(new AretinoAppleJuice()); });
            Assert.PropertyChanged(o, "Calories", () => { o.Add(new AretinoAppleJuice()); });
        }

        [Fact]
        public void RemovingItemUpdates()
        {
            var a = new AretinoAppleJuice();
            Order o = new Order(1);
            o.Add(a);
            Assert.PropertyChanged(o, "Subtotal", () => { o.Remove(a); });
            o.Add(a);
            Assert.PropertyChanged(o, "Tax", () => { o.Remove(a); });
            o.Add(a);
            Assert.PropertyChanged(o, "Total", () => { o.Remove(a); });
            o.Add(a);
            Assert.PropertyChanged(o, "Calories", () => { o.Remove(a); });
            
        }

        [Fact]
        public void ChangingItemUpdates()
        {
            Order o = new Order(1);
            var a = new AretinoAppleJuice();
            o.Add(a);
            Assert.PropertyChanged(o, "Subtotal", () => { a.Size = Size.Large; });
            Assert.PropertyChanged(o, "Tax", () => { a.Size = Size.Large;  });
            Assert.PropertyChanged(o, "Total", () => { a.Size = Size.Large; });
            Assert.PropertyChanged(o, "Calories", () => { a.Size = Size.Large; });
            
        }

        [Fact]
        public void ShouldHaveCorrectTotals()
        {
            Order o = new Order(1);
            var a = new AretinoAppleJuice();
            o.Add(new AretinoAppleJuice());
            Assert.Equal(a.Price, o.Subtotal );
            Assert.Equal("1",o.OrderNumber.ToString());
            Assert.Equal(a.Price * o.SalesTaxRate , o.Tax);
            Assert.Equal(a.Price * o.SalesTaxRate + a.Price, o.Total);
            Assert.Equal(a.Calories, o.Calories);
            o.SalesTaxRate = 5;
            Assert.Equal(5, o.SalesTaxRate);
        }
    }
}
