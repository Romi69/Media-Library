using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using MediaLibrary.Model;

namespace Repository.Test
{
    [Category("Unit")]
    [TestFixture]
    public class RepositoryUnitTest
    {
        [Test]
        public void RepositoryUnitTest_Param_AddedParamShouldBeAppearInRepo()
        {
            /*using( var db = new DataContext())
            {
                var sut = new GeneralRepository<Param>(db);

                Param newParam = new Param() { ParamType = ParamType.Language, ParamId = 1, StringValue = "magyar" };
                sut.Add(newParam);

                Param foundedParam = sut.Find(newParam.Id);

                Assert.IsNotNull(foundedParam);
                Assert.AreEqual(newParam.StringValue, foundedParam.StringValue);
            }*/
            
        }
    }
}
