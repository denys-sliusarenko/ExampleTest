using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    public class HttpClientService
    {
        private static readonly Lazy<HttpClient> lazy = new Lazy<HttpClient>(() => new HttpClient());

        public static HttpClient HttpClient
        {
            get
            {
                return Nested.http;
            }
        }

        public HttpClient HttpClientLazy
        {
            get
            {
                return lazy.Value;
            }
        }
        private class Nested
        {
            static Nested()
            {

            }
            internal static readonly HttpClient http = new HttpClient();
        }
    }
}
