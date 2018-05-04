using ServiceStack;
using SSResponseTrackingInProcGatewayReqs.ServiceModel;

namespace SSResponseTrackingInProcGatewayReqs.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            Gateway.Publish(new InProcRequest1());
            Gateway.Publish(new InProcRequest2());

            return "hello";
        }

        public object Any(InProcRequest1 request)
        {
            return "InProcRequest1 response";
        }

        public object Any(InProcRequest2 request)
        {
            return "InProcRequest2 response";
        }
    }
}