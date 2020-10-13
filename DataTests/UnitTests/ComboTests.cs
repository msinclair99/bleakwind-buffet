/*
 * Author: Matthew Sinclair
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void Implements()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        


    }
}
