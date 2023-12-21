using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitsTests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(new User());

            // Act
            var result = reservation.CanBeCancelledBy(adminUser);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var anotherUser = new User();
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(anotherUser);

            // Assert
            Assert.IsFalse(result);
        }
    }
}