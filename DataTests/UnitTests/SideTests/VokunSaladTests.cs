/*
 * Author: Zachery Brunner
 * Edited by: Matthew Sinclair
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests the VokunSalad class in the Data library
    /// </summary>
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldReturnCorrectDecription()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", vs.Description);
        }

        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {

            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vs);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(vs, "Name", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Medium;
            });

            Assert.PropertyChanged(vs, "Name", () =>
            {
                vs.Size = Size.Large;
            });
            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Large;
            });
            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Large;
            });

            Assert.PropertyChanged(vs, "Name", () =>
            {
                vs.Size = Size.Small;
            });
            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Small;
            });
            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Small;
            });
        }


        [Fact]
        public void ShouldBeAIOrderItem()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }


        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }


        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }
    }
}