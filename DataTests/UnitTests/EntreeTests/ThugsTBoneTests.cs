/*
 * Author: Zachery Brunner
 * Edited by: Matthew Sinclair
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests the ThugsTBone class in the Data library
    /// </summary>
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectDecription()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", tt.Description);
        }

        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }


        [Fact]
        public void ShouldBeAIOrderItem()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal(6.44, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal((uint)982, tt.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tt.ToString());
        }
    }
}