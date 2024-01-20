using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    abstract class HttpClientProxyFactory
    {
        public abstract Requests CreateRequestMessages();
    }
}
