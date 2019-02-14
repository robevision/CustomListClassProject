using System;
using Custom_List_Project;
using System.Collections.Generic;
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>() {3, 4, 6, 13, 18, 23, 34};
            int expectedResult = 7;
            //Act
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Int_FirstArrayPositon()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
            int value = 3;
            int expectedResult = 3;
            //Act
            myList.Add(value);
            int actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddTwo_Int_FirstArrayPosition()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 3;
            //Act
            myList.Add(value);
            myList.Add(value1);
            int actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddTwo_Int_SecondArrayPosition()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void Count_Int_Capacity()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<string> myList = new CustomBuiltList<string>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>() {1};
            int value = 1;
            int expectedResult = 0;
            //Act
            myList.Remove(value);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_Int_EndOfLongList()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>() {1,5,8,7,24,57,68,4,5,6,3,4,5,9,10,30,23,43,45};
            int value = 45;
            int expectedResult = 43;
            //Act
            myList.Remove(value);
            int actualResult = myList[17];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Int_EndOfLongList()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>() {1, 5, 8, 7, 24, 57, 68, 4, 5, 6, 3, 4, 5, 9, 10, 30, 23, 43};
            int value = 45;
            int expectedResult = 43;
            //Act
            myList.Add(value);
            int actualResult = myList[17];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_String_InList()
        {
            //Arrange
            CustomBuiltList<string> myList = new CustomBuiltList<string>() {"test"};
            string value = "test";
            int expectedResult = 0;
            //Act
            myList.Remove(value);
            int actualResult = myList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Find_String_InList()
        {
            //Arrange
            CustomBuiltList<string> myList = new CustomBuiltList<string>() { "test", "thing","otherThing" };
            string value = "thing";
            string expectedResult = "otherThing";
            //Act
            myList.Remove(value);
            string actualResult = myList[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void FindAfterAdd_String_InList()
        {
            //Arrange
            CustomBuiltList<string> myList = new CustomBuiltList<string>();
            string value = "thing";
            string expectedResult = "thing";
            //Act
            myList.Add(value);
            string actualResult = myList[0];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Find_Int_InList()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>() { 1, 2, 4, 6, 7, 20, 3, 5 };
            int value = 3;
            int expectedResult = 5;
            //Act
            myList.Remove(value);
            int actualResult = myList[6];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddAndRemove_Int_InList()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
            CustomBuiltList<int> myList = new CustomBuiltList<int>();
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
        [TestMethod]
        public void Convert_Double_ToString()
        {
            //Arrange
            CustomBuiltList<double> myList = new CustomBuiltList<double>() { 1.337, 1.338, 1.339, 4.1 };
            
            string expectedResult = "1.3371.3381.3394.1";
            //Act
            string actualResult = myList.ToString();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Does_Return_Value()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>() { 4 };
           
            bool expectedResult = true;
            bool actualResult;
            //Act
            myList.ToString();
            if(myList.ToString() == "4")
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Convert_Int_ToString()
        {
            //Arrange
            CustomBuiltList<int> myList = new CustomBuiltList<int>() { 1, 3, 3, 7 };
           
            string expectedResult = "1337";
            //Act
            string actualResult = myList.ToString();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ZipTwo_Int_Lists()
        {
            //Arrange
            CustomBuiltList<int> myList0 = new CustomBuiltList<int>() { 1, 3, 3, 7 };
            CustomBuiltList<int> myList1 = new CustomBuiltList<int>() { 4, 5, 6, 9 };
            CustomBuiltList<int> myList2 = new CustomBuiltList<int>();
            CustomBuiltList<int> expectedResult = new CustomBuiltList<int>{ 1, 4, 3, 5, 3, 6, 7, 9 };
            //Act
            CustomBuiltList<int> actualResult = myList2.Zip(myList1,myList2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Count_Int_InZip()
        {
            CustomBuiltList<int> myList0 = new CustomBuiltList<int>() { 1, 3, 3, 7 };
            CustomBuiltList<int> myList1 = new CustomBuiltList<int>() { 4, 5, 6, 9 };
            CustomBuiltList<int> myList2 = new CustomBuiltList<int>();
            int expectedResult = 8;
            CustomBuiltList<int> actualResult = myList2.Zip(myList1, myList2);
            Assert.AreEqual(expectedResult, (myList0.Count + myList1.Count));
        }
    }
}
