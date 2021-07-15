using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [TestClass]

    public class CollectionSampleTest
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrage
            Customer[] customers = new Customer[2] { new Customer { FirstName = "Jhon", LastName = "Ford" },
                new Customer { FirstName = "Billy", Last Name = "Wilder" } };

            int index = 1;
            Customer expect = customers[1];

            //Act
            Customer actual = CollectionSample.GetCustomer(customers, index);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldTrowIndexOutofRangeException()
        {
            //Arrage
            Customer[] customers = new Customer[2] { new Customer { FirstName = "Jhon", LastName = "Ford" },
                new Customer { FirstName = "Billy", Last Name = "Wilder" } };

            int index = 3;
            Customer expect = customers[1];

            //Act
            Customer actual = CollectionSample.GetCustomer(customers, index);

            //Assert
            

        }
    }
