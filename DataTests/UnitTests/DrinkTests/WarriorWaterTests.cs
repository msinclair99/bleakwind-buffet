/*
 * Author: Matthew Sinclair
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests the WarriorWater class in the Data library
    /// </summary>
    public class WarriorWaterTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ChangingIceInvokesPropertyChanged()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });
        }

        [Fact]
        public void ChangingLemonInvokesPropertyChanged()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingPropertyInvokesSpecialInstructions()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = false;
            });

            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = true;
            });

            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = true;
            });
            
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Large;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Large;
            });

            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Small;
            });
        }


        [Fact]
        public void ShouldBeAIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);

        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);

        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce)
            {
                if (includeLemon)
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                }
            }
            else
            {
                if (includeLemon)
                {
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.Empty(ww.SpecialInstructions);
                }

            }

        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]

        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
