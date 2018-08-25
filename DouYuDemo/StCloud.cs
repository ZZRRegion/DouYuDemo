using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;

namespace DouYuDemo
{
    public class StCloud
    {
        private HttpClient httpClient;
        private string baseUrl => "http://open.douyucdn.cn/api/";
        public StCloud()
        {
            this.httpClient = new HttpClient();
        }
        public JObject Post(string api, Dictionary<string, string> dict)
        {
            FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(dict);
            string url = $"{this.baseUrl}{api}";
            HttpResponseMessage httpResponseMessage = this.httpClient.PostAsync(url, formUrlEncodedContent).Result;
            string content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            JObject json = JObject.Parse(content);
            return json;
        }
        public JObject Get(string api)
        {
            string url = $"{this.baseUrl}{api}";
            string content = this.httpClient.GetStringAsync(url).Result;
            JObject json = JObject.Parse(content);
            return json;
        }
    }
}
