using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract(Name ="AddOne")]
        int Add();
        [OperationContract]
        int Add(int i);
        [OperationContract(Name ="SubOne")]
        int Sub();
        [OperationContract]
        int Sub(int i);
        [OperationContract]
        int GetResult();
        [OperationContract]
        void Clear();
    }
}
