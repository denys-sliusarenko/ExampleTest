using HttpAbstractFactoryTest.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    class HttpClientProxy
    {
        private Requests requests;
        public HttpClientProxy(HttpClientProxyFactory factory)
        {
            requests = factory.CreateRequestMessages();
        }

        public T Get<T>(string path)
        {
            HttpRequestMessage requestMessage = requests.CreateGetRequest(path);
            HttpResponseMessage response = HttpClientService.HttpClient.SendAsync(requestMessage).Result;
           
            string json = response.Content.ReadAsStringAsync().Result;
            T content = JsonSerializer.Deserialize<T>(json);
            return content;
        }

        public T Post<T>(string path, object data)
        {
            HttpRequestMessage requestMessage = requests.CreatePostRequest(path, data);
            
            HttpResponseMessage response = HttpClientService.HttpClient.SendAsync(requestMessage).Result ;
            T content = JsonSerializer.Deserialize<T>(response.Content.ReadAsStringAsync().Result);
            return content;
        }
    }
}
