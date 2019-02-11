using System;
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
            int value = 0;
            myList.Count = 4;
            int expectedResult = 5;
            ////Act
            myList.Add(value);
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

        //    //Assert
        //    Assert.AreEqual(expectedResult, myList[0]);
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

        //    //Assert
        //    Assert.AreEqual(expectedResult, myList[0]);
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
        //[testmethod]
        //public void Count_Int_Capacity()
        //{
        //    //Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int value = 1;
        //    int expectedResult = 4;
        //    //Act
        //    myList.Add(value);
        //    actualResult=myList.Capacity();
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
        //[TestMethod]
        //public void Count_Int_CountList()
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
