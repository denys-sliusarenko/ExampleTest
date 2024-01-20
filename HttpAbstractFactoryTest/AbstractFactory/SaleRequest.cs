using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    public class SaleRequest : Requests
    {
        private string _scope = "";
        private readonly string _tenantId = "";

        protected override string BaseUrl
        {
            get
            {
                return "";
            }
        }

        protected override void SetHeaders(HttpRequestMessage requestMessage)
        {
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AzureAccess.GetAccessToken(_scope, _tenantId));
        }
    }

}
