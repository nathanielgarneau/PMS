using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMS.Xam.WebApiClient.Test.Interfaces;

namespace PMS.Xam.WebApiClient.Test
{
    [TestClass]
    public class ColourUnitTest : ITestWebClient
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(ApiClient.Colour);
        }

        [TestMethod]
        public void GetListTest()
        {
            var list = ApiClient.Colour.GetList(1, 2, 3, 4, 5);
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetSingleTest()
        {
            var single = ApiClient.Colour.GetSingle(1);
            Assert.IsNotNull(single);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var all = ApiClient.Colour.GetAll();
            Assert.IsNotNull(all);
        }

        [TestMethod]
        public void AddTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void AddManyTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void UpdateTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void UpdateManyTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveManyTest()
        {
            throw new NotImplementedException();
        }
    }
}