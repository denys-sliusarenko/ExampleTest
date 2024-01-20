using HttpAbstractFactoryTest.AbstractFactory;
using System;

namespace HttpAbstractFactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClientProxy sale = new HttpClientProxy(new SaleHttp());
            sale.Get<object>("path");
            sale.Post<object>("path", new object());
        }
    }
}
