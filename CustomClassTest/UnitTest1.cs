﻿using System;
using Custom_List_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Push_Int_IntoList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 1;
            ////Act
            myList.Add(value);
            int actualResult = myList.Count;
            ////Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Expand_Int_Count()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 4;
            int value2 = 7;
            int value3 = 3;
            int value4 = 2;
            int expectedResult = 5;
            ////Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            int actualResult = myList.Count;

            ////Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Push_OneInt_IntoList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int expectedResult = 1;
            //Act
            myList.Add(value);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void Count_Int_InList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 1;
            int expectedResult = 2;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CreateMultiple_Int_List()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() {3, 4, 6, 13, 18, 23, 34};
            int expectedResult = 7;
            //Act
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //[TestMethod]
        //public void Add_Int_FirstArrayPositon()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int value = 3;
        //    int expectedResult = 3;
        //    //Act
        //    myList.Add(value);
        //    int actualResult = myList[0];

        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        //[TestMethod]
        //public void AddTwo_Int_FirstArrayPosition()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int value = 3;
        //    int value1 = 5;
        //    int expectedResult = 3;
        //    //Act
        //    myList.Add(value);
        //    myList.Add(value1);
        //    int actualResult = myList[0];

        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        //[TestMethod]
        //public void AddTwo_Int_SecondArrayPosition()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int value = 3;
        //    int value1 = 5;
        //    int expectedResult = 5;
        //    //Act
        //    myList.Add(value);
        //    myList.Add(value1);

        //    //Assert
        //    Assert.AreEqual(expectedResult, myList[1]);
        //}
        [TestMethod]
        public void Count_Int_Capacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int expectedResult = 4;
            //Act
            myList.Add(value);
            int actualResult = myList.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //test for when overloading is implemented
        //[TestMethod]
        //public void AddMultiple_Int_InList()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int value = 1;
        //    int value1 = 4;
        //    int expectedResult = 4;
        //    //Act
        //    myList.Add(value, value1);
        //    int actualResult = myList.Count;
        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        [TestMethod]
        public void Count_String_InList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "test";
            int expectedResult = 1;
            ////Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void Remove_Int_InList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() {1};
            int value = 1;
            int expectedResult = 0;
            //Act
            myList.Remove(value);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_String_InList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() {"test"};
            string value = "test";
            int expectedResult = 0;
            //Act
            myList.Remove(value);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_String_InList1()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() { "test", "thing","otherThing" };
            string value = "thing";
            string expectedResult = "otherThing";
            //Act
            myList.Remove(value);
            string actualResult = myList[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //public void Find_Int_InList()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>() {1,2,4,6,7,20,3,5};
        //    int value = 3;
        //    int expectedResult = 5;
        //    //Act
        //    myList.Remove(value);
        //    int actualResult = myList[6];
        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        [TestMethod]
        public void AddAndRemove_Int_InList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int expectedResult = 0;
            //Act
            myList.Add(value);
            myList.Remove(value);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveAndAdd_Int_InList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 4;
            int expectedResult = 1;
            //Act
            myList.Add(value);
            myList.Remove(value);
            myList.Add(value1);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //[TestMethod]
        //public void Count_String_CountList()
        //{
        //    //Arrange
        //    CustomList<string> myList = new CustomList<string>()
        //    {
        //        //need a custom IEnumerable that allows iterable instances. ie display value 1, display value 2, etc.
        //        //9
        //    };
        //    int value = 1;

        //    //Act
        //    //Assert
        //}
    }
}
