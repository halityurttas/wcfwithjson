using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    
    public class Service1 : IService1
    {
        public string GetData(int value)
        {

            WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json;
            return string.Format("You entered: {0}", value);
        }
    }
}
