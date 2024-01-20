using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    class SaleHttp : HttpClientProxyFactory
    {
        public override Requests CreateRequestMessages()
        {
            return new SaleRequest();
        }
    }
}
