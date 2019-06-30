using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;

namespace CalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CalcService : ICalcService
    {
        private int result;

        public int Add()
        {
            return Add(1);
        }

        public int Add(int i)
        {
            result = result + i;
            return result;
        }

        public void Clear()
        {
            result = 0;
        }

        public int GetResult()
        {
            return result;
        }

        public int Sub()
        {
            return Sub(1);
        }

        public int Sub(int i)
        {
            result = result - 1;
            return result;
        }
    }

    //Az IIS Hostoláshoz(WAS - Windows Activation Service)
    class CalcServiceFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
}
