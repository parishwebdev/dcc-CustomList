using System;
using DCC_CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Aranage
            CustomList<int> list = new CustomList<int>();
            int valueToAdd = 5;
            //Act
            list.Add(valueToAdd);
            //Assert
            Assert.AreEqual(valueToAdd, list[0]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arranage
            //Act
            //Assert
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arranage
            //Act
            //Assert
        }
    }
}
