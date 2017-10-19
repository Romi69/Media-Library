using System;
using NUnit.Framework;
using MediaLibrary.Model;

namespace Repository.Test
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void RepositoryTest_Param_AddedParamShouldBeAppearInRepo()
        {
            UnitOfWork uow = new UnitOfWork();
            Param param = new Param() { ParamType = ParamType.MediaType, ParamId = 1, StringValue = "CD"};

            uow.ParamRepository.Add(param);
            uow.Save();

            Param newParam = uow.ParamRepository.Find(param.Id);

            Assert.IsNotNull(newParam);
            Assert.AreEqual(param.StringValue, newParam.StringValue);
        }
    }
}