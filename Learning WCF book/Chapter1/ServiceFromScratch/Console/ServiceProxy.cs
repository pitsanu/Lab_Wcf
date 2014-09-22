using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Console
{
    [ServiceContract(Namespace = "my.helloindigo.service.v1")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }
}
