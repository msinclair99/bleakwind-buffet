﻿/*
 * Author: Zachery Brunner
 * Edited by: Matthew Sinclair
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests the CandlehearthCoffee class in the Data library
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldReturnCorrectDecription()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", chc.Description);
        }

        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chc);
        }

        [Fact]
        public void ChangingIceInvokesPropertyChanged()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = false;
            });
            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = true;
            });
        }

        [Fact]
        public void ChangingCreamInvokesPropertyChanged()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = true;
            });
            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = false;
            });
        }


        [Fact]
        public void ChangingDecafInvokesPropertyChanged()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = true;
            });
            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = false;
            });

            Assert.PropertyChanged(chc, "Name", () =>
            {
                chc.Decaf = true;
            });
            Assert.PropertyChanged(chc, "Name", () =>
            {
                chc.Decaf = false;
            });
        }

        [Fact]
        public void ChangingPropertyInvokesSpecialInstructions()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "SpecialInstructions", () =>
            {
                chc.Ice = false;
            });

            Assert.PropertyChanged(chc, "SpecialInstructions", () =>
            {
                chc.RoomForCream = true;
            });

        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Name", () =>
            {
                chc.Size = Size.Medium;
            });
            Assert.PropertyChanged(chc, "Price", () =>
            {
                chc.Size = Size.Medium;
            });
            Assert.PropertyChanged(chc, "Calories", () =>
            {
                chc.Size = Size.Medium;
            });

            Assert.PropertyChanged(chc, "Name", () =>
            {
                chc.Size = Size.Large;
            });
            Assert.PropertyChanged(chc, "Price", () =>
            {
                chc.Size = Size.Large;
            });
            Assert.PropertyChanged(chc, "Calories", () =>
            {
                chc.Size = Size.Large;
            });

            Assert.PropertyChanged(chc, "Name", () =>
            {
                chc.Size = Size.Small;
            });
            Assert.PropertyChanged(chc, "Price", () =>
            {
                chc.Size = Size.Small;
            });
            Assert.PropertyChanged(chc, "Calories", () =>
            {
                chc.Size = Size.Small;
            });
        }


        [Fact]
        public void ShouldBeAIOrderItem()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(chc);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = Size.Large;
            Assert.Equal(Size.Large, chc.Size);
            chc.Size = Size.Medium;
            Assert.Equal(Size.Medium, chc.Size);
            chc.Size = Size.Small;
            Assert.Equal(Size.Small, chc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(price, chc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(cal, chc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = includeIce;
            chc.RoomForCream = includeCream;
            if (includeIce)
            {
                if (includeCream)
                {
                    Assert.Contains("Add ice", chc.SpecialInstructions);
                    Assert.Contains("Add cream", chc.SpecialInstructions);
                }
                else
                {
                    Assert.Contains("Add ice", chc.SpecialInstructions);
                }
            }
            else
            {
                if (includeCream)
                {
                    Assert.Contains("Add cream", chc.SpecialInstructions);
                }
                else
                {
                    Assert.Empty(chc.SpecialInstructions);
                }

            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            chc.Decaf = decaf;
            Assert.Equal(name, chc.ToString());
        }
    }
}
