using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sarfiat.Data;
using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarfiat.Data.SqlServer;

namespace Sarfiat.Test
{
    [TestClass]
    public class CategoriesEntityTests
    {
        IDataHelper<Categories> dataHelper;
        public CategoriesEntityTests()
        {
            dataHelper = new CategoriesEntity();
        }
        [TestMethod]
        public void AddTest()
        {
            //Arrange (Set)
            Categories categories = new Categories { 
                Name = "الاسم تجريبي",
                Details="rrrrrrrrrrr",
                Type="صرف",
                Balance=1000,
                AddedDate=DateTime.Now,
            };
            //Act and except (Get)
            int act = dataHelper.Add(categories);
            int except = 1;
            //Assert (Test)
            Assert.AreEqual(act, except);

        }
        [TestMethod]
        public void EditTest()
        {
            //Arrange (Set)
            Categories categories = new Categories
            {
                Id=1,
                Name = "تجريبي",
                Details = "rryyyyyyyyrrrr",
                Type = "صرف",
                Balance = 4000,
                AddedDate = DateTime.Now,
            };
            //Act and except (Get)
            int act = dataHelper.Edit(categories);
            int except = 1;
            //Assert (Test)
            Assert.AreEqual(act, except);

        }
        [TestMethod]
        public void DataTest()
        {
            //Arrange (Set)

            //Act and except (Get)
            var act = dataHelper.GetAllData();
            int except = 1;
            //Assert (Test)
            Assert.IsNotNull(act);

        }
    }
}
