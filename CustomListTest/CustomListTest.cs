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

        [TestMethod]
        public void Remove_And_Count_Is_One_Shorter_Than_Before()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            int valueToRemove = 54;

            list.Add(2);
            list.Add(6);
            list.Add(18);
            list.Add(54);
            list.Add(162);
            list.Add(486);
            int expectedCount = 5;
            //Act
            list.Remove(valueToRemove);
            int actualCount = list.Count;
            //Assert
            Assert.AreEqual(expectedCount,actualCount);
        }

        [TestMethod]
        public void Value_Not_Contained_In_List_When_Removed()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            int valueToRemove = 54;

            list.Add(2);
            list.Add(6);
            list.Add(18);
            list.Add(54);
            list.Add(162);
            list.Add(486);
            bool expectedResult = false;
            //Act
            list.Remove(valueToRemove);
            bool actualResult = list.Contains(valueToRemove);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void List_Values_Returned_As_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            
            list.Add(2);
            list.Add(5);
            string expectedResult = "2 5 ";
            //Act
            string actualResult = list.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void String_Returned_Length()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            list.Add(2);
            list.Add(5);
            int expectedResult = 4;
            //Act
            string actualResult = list.ToString();
            int actualLength = actualResult.Length;
            Assert.AreEqual(expectedResult, actualLength);
        }

        [TestMethod]
        public void Add_Operater_Check_If_Value_At_Specfic_Index()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list1.Add(2);
            list1.Add(5);
            list2.Add(6);
            list2.Add(9);
            CustomList<int> expectedList = new CustomList<int>() { 2, 5, 6, 9 };
            int expectedResult = 6;
            int indexToCheck = 2;
            //Act
            CustomList<int> actualList = list1 + list2;
            int actualResult = actualList[indexToCheck];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_Operater_Check_New_List_Count()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list1.Add(2);
            list1.Add(5);
            list2.Add(6);
            list2.Add(9);
            CustomList<int> expectedList = new CustomList<int>() { 2, 5, 6, 9 };
            int expectedCount = 4;
            //Act
            CustomList<int> actualList = list1 + list2;
            int actualCount = actualList.Count;
            //Assert
            Assert.AreEqual(actualCount, expectedCount);
        }
        [TestMethod]
        public void Subtract_Operater_Check_Value_At_Specific_Index()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 1, 6 };
            CustomList<int> expectedList = new CustomList<int>() {2,3};
            int expectedIndex = 1;
            int valueToFind = 3;
            //Act
            CustomList<int> actualList = list1 - list2;
            int actualIndex = actualList.IndexOf(valueToFind);
            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void Subtract_Operater_Check_Count_Of_Resulting_List()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 1, 6 };
            CustomList<int> expectedList = new CustomList<int>() { 2, 3 };
            int expectedCount = 2;
            //Act
            CustomList<int> actualList = list1 - list2;
            int actualCount = actualList.Count;
            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Zip_Check_Index_If_One_List_Is_Longer()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3, 7 };
            CustomList<int> myList2 = new CustomList<int>() { 4, 5, 6 };
            int expectedResult = 6;
            //Act
            CustomList<int> actualZipList = myList1.Zip(myList2);
            int actualResult = actualZipList.IndexOf(7);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        
        [TestMethod]
        public void Zip_Check_If_New_List_Contains_A_Value()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> myList2 = new CustomList<int>() { 4, 5, 6 };
            bool expectedResult = true;
            //Act
            CustomList<int> actualZipList = myList1.Zip(myList2);
            bool actualResult = actualZipList.Contains(5);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        
    }
}
