using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace HttpAbstractFactoryTest.AbstractFactory
{
    public abstract class Requests
    {
        protected abstract string BaseUrl { get; }
        protected abstract void SetHeaders(HttpRequestMessage requestMessage);
        public HttpRequestMessage CreateGetRequest(string path)
        {
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(BaseUrl + path)
            };
            SetHeaders(requestMessage);
            return requestMessage;
        }

        public HttpRequestMessage CreatePostRequest(string path, object data)
        {
            string json = JsonSerializer.Serialize(data);
            StringContent stringContent = new StringContent(json);
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                Content = stringContent,
                RequestUri = new Uri(BaseUrl + path)
            };
            SetHeaders(requestMessage);
            return requestMessage;
        }
    }
}
