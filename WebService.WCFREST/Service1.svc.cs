using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebService.WCFREST
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        [OperationContract]
        [WebGet(UriTemplate="/ToUpper/{input}", ResponseFormat = WebMessageFormat.Json)]
        public string ToUpper(string input)
        {
            return input.ToUpper();
        }
    }
}
