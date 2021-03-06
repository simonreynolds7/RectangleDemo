﻿using System;
using System.Reflection;
using NUnit;
using NUnit.Framework;

using RectangleDemoCs;

namespace RectangleDemoTests
{
    [TestFixture]
    public class RectangleDemoCsTests
    {
        [Test]
        public void CanConstructRectangle()
        {
            var rectangle = new Rectangle(10, 10);

            Assert.IsTrue(rectangle.IsSquare());
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ThrowsException_WhenLengthIsZero()
        {
            var rectangle = new Rectangle(0, 10);
        }

        [Test]
        public void GivenLength10AndWidth5_AreaIs50_PermieterIs30()
        {
            var rectangle = new Rectangle(10, 5);

            Assert.That(rectangle.Area, Is.EqualTo(50));
            Assert.That(rectangle.Perimeter, Is.EqualTo(30));
        }
    }
}
