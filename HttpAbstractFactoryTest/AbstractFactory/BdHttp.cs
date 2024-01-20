using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    class BdHttp : HttpClientProxyFactory
    {
        public override Requests CreateRequestMessages()
        {
            return new BdRequests();
        }
    } 
}
