using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHero
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void TestSearchHero()
        {
            superHeroApp.Models.RequestAccess.RequestAccess method = new superHeroApp.Models.RequestAccess.RequestAccess();
            string result = await method.SearchHero("");
            result.Contains("id");
        }

        [TestMethod]
        public async void TestGetHeroValidHero()
        {
            superHeroApp.Models.RequestAccess.RequestAccess method = new superHeroApp.Models.RequestAccess.RequestAccess();
            string result = await method.GetHero(2);
            Assert.IsTrue(!result.Contains("error"));
        }


        [TestMethod]
        public async void TestGetHeroInvalidHero()
        {
            superHeroApp.Models.RequestAccess.RequestAccess method = new superHeroApp.Models.RequestAccess.RequestAccess();
            string result = await method.GetHero(0);
            Assert.IsTrue(result.Contains("error"));
        }
    }
}
