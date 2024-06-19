using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Class1
    {
        [Test]
        public void CalculateDiscountedPrice_PartTime_NoDiscountApplied()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.PartTime, Price = 1000m };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(1000m, discountedPrice);
            // Selected this test to ensure that no discount is applied for PartTime employees
        }

        [Test]
        public void CalculateDiscountedPrice_PartialLoad_7PercentDiscountApplied()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.PartialLoad, Price = 1000m };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(930m, discountedPrice);
            // Selected this test to ensure that 7% discount is applied for PartialLoad employees
        }

        [Test]
        public void CalculateDiscountedPrice_FullTime_12PercentDiscountApplied()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.FullTime, Price = 1000m };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(880m, discountedPrice);
            // Selected this test to ensure that 12% discount is applied for FullTime employees
        }

        [Test]
        public void CalculateDiscountedPrice_CompanyPurchasing_22PercentDiscountApplied()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.CompanyPurchasing, Price = 1000m };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(780m, discountedPrice);
            // Selected this test to ensure that 22% discount is applied for CompanyPurchasing employees
        }

        [Test]
        public void CalculateDiscountedPrice_PriceZero_NoDiscountApplied()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.PartTime, Price = 0m };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(0m, discountedPrice);
            // Selected this test to ensure that no discount is applied when the price is zero
        }

        [Test]
        public void CalculateDiscountedPrice_PriceNegative_ThrowsArgumentException()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount { EmployeeType = EmployeeType.PartTime, Price = -100m };

            // Act and Assert
            Assert.Throws<ArgumentException>(() => employeeDiscount.CalculateDiscountedPrice());
            // Selected this test to ensure that an exception is thrown when the price is negative
        }
    }
}
}
