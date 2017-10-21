using System;
using NUnit.Framework;
using MediaLibrary.Model;
using System.Data.Entity.Infrastructure;

namespace Repository.Test
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void RepositoryTest_Param_AddedParamShouldBeAppearInRepo()
        {
            UnitOfWork uow = new UnitOfWork();
            Param param = new Param() { ParamType = ParamType.MediaType, ParamId = 1, StringValue = "CD+" };

            uow.ParamRepository.Add(param);
            uow.Save();

            Param newParam = uow.ParamRepository.Find(param.Id);

            Assert.IsNotNull(newParam);
            Assert.AreEqual(param.StringValue, newParam.StringValue);
        }

        [Test]
        public void RepositoryTest_Param_DeletedParamShouldBeDisappearFromRepo()
        {
            UnitOfWork uow = new UnitOfWork();
            Param oldParam = uow.ParamRepository.Find(10);
            uow.ParamRepository.Remove(oldParam);
            uow.Save();

            Param newParam = uow.ParamRepository.Find(10);
            Assert.IsNull(newParam);
        }

        [Test]
        public void RepositoryTest_Param_UpdatedParamShouldBeAppearInRepo()
        {
            UnitOfWork uow = new UnitOfWork();
            String newName = "CD-RW";

            Param oldParam = uow.ParamRepository.Find(11);
            oldParam.StringValue = newName;

            uow.ParamRepository.Update(oldParam);
            uow.Save();

            Param newParam = uow.ParamRepository.Find(11);
            Assert.AreEqual(newName, newParam.StringValue);
        }

        [Test]
        public void RepositoryTest_Param_FindParam()
        {
            UnitOfWork uow = new UnitOfWork();

            Param param = uow.ParamRepository.Find(1);
            Assert.AreEqual("Box 1 (600)", param.StringValue);
        }

        //[Test]
        //public void RepositoryTest_Param_DeletedParam1ShouldBeThrowException()
        //{
        //    UnitOfWork uow = new UnitOfWork();

        //    Param param = uow.ParamRepository.Find(10);
        //    uow.ParamRepository.Remove(param);
        //    uow.Save();

        //    Assert.Throws<DbUpdateException>(uow.Save);
        //}
    }
}