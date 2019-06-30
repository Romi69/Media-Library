using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaLibrary.Model;
using System.Linq;

namespace MediaLibrary.Test
{
    /// <summary>
    /// Summary description for MediaLibrary
    /// </summary>
    [TestClass]
    public class MediaLibraryTest
    {
        public MediaLibraryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ML_Param_CountShouldBeEqualTo0()
        {
            // Act
            using(DataContext db = new DataContext())
            {
                // Arrange
                int count = db.Params.Count();

                //Assert
                Assert.AreEqual(10, count);
            }
        }

        [TestMethod]
        public void ML_Param_CountShouldBeEqualTo1()
        {
            // Act
            using (DataContext db = new DataContext())
            {
                Param pr = new Param() { ParamId = 1, ParamType = ParamType.Box, IntValue = 300 };

                db.Params.Add(pr);
                db.SaveChanges();

                int count = db.Params.Count();
                Assert.AreEqual(11, count);

                db.Params.Remove(pr);
                db.SaveChanges();
            }            
        }

        [TestMethod]
        public void ML_AddBoxToParamTable()
        {
            using( DataContext db = new DataContext())
            {
                int oldsize = db.Params.Count();

                Box box = new Box() { Name = "Box 1 (600)", Capacity = 600 };
                db.Params.Add(box.ConvertToParam());
                db.SaveChanges();                

                //var curBox = db.Params.Find(x => x.ParamType == ParamType.Box && x.)
                db.Params.Remove(box.ConvertToParam());
                db.SaveChanges();
                
                Assert.AreEqual(oldsize, db.Params.Count());
            }
            
            
        }
    }
}
