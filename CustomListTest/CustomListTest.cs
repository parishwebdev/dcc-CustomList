using System;
using DCC_CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_Value_To_List_Increase_List_Count()
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
        public void Count_Add_Num_Of_Values_Return_Amount_Of_Values()
        {
            //Arranage
            CustomList<int> list = new CustomList<int>();
            int count = 5;
            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //Assert
            Assert.AreEqual(count, list.Count);
        }

        //capacity test
        [TestMethod]
        public void Adding_More_Than_Capacity_Expect_Expansion_And_Values_Retained()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int sixthValue = 486;
            //Act
            list.Add(2);
            list.Add(6);
            list.Add(18);
            list.Add(54);
            list.Add(162);
            list.Add(486);
            //Assert
            Assert.AreEqual(sixthValue,list[5]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_Item_Index_Out_Of_Range_Throw_ArgumentOutOfRangeException()
        {
            //Arranage
            CustomList<int> list = new CustomList<int>();
            int value = 8;
            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Remove(value);
        }

    }
}
