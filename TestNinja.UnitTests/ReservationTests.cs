//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        //[TestMethod]
        //// Method under test - Scenario testing - Behavior 
        //public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        //{
        //    // Arrange
        //    var reservation = new Reservation();

        //    // Act
        //    var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //    // Assert
        //    Assert.IsTrue(result);

        //}
        //[TestMethod]
        //// Method under test - Scenario testing - Behavior 
        //public void CanBeCancelledBy_ReservationMaker_ReturnsTrue()
        //{
        //    // Arrange
        //    var user = new User();
        //    var reservation = new Reservation { MadeBy = user };

        //    // Act
        //    var result = reservation.CanBeCancelledBy(user);

        //    // Assert
        //    Assert.IsTrue(result);

        //}

        //[TestMethod]
        //// Method under test - Scenario testing - Behavior 
        //public void CanBeCancelledBy_NonReservationMaker_ReturnsFalse()
        //{
        //    // Arrange
        //    var reservation = new Reservation { MadeBy = new User() };

        //    // Act
        //    var result = reservation.CanBeCancelledBy(new User());

        //    // Assert
        //    Assert.IsFalse(result);

        //}

        [Test]
        // Method under test - Scenario testing - Behavior 
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result == true);

        }
        [Test]
        // Method under test - Scenario testing - Behavior 
        public void CanBeCancelledBy_ReservationMaker_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result == true);

        }

        [Test]
        // Method under test - Scenario testing - Behavior 
        public void CanBeCancelledBy_NonReservationMaker_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.That(result == false);

        }
    }
}
