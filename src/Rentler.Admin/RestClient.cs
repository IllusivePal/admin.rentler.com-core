using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Rentler.Admin
{
    public abstract class RestClient
    {
        protected HttpClient client;
        private string username;
        private string password;

        private string credentials
        {
            get
            {
                return Convert.ToBase64String(
                    Encoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", this.username, this.password)));
            }
        }

        public RestClient(string baseUri)
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri(baseUri);
        }

        public RestClient(string baseUri, string username, string password)
            : this(baseUri)
        {
            this.username = username;
            this.password = password;
            this.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", this.credentials);
        }

        protected HttpResponseMessage HttpGet(string uri)
        {
            var result = this.client.GetAsync(uri).Result;
            return result;
        }

        protected string Get(string uri)
        {
            var result = this.client.GetAsync(uri).Result;
            return result.Content.ReadAsStringAsync().Result;
        }

        protected string Post(string uri, List<KeyValuePair<string, string>> parameters)
        {
            var content = new FormUrlEncodedContent(parameters);
            var result = this.client.PostAsync(uri, content).Result;
            return result.Content.ReadAsStringAsync().Result;
        }

        protected string PostAsJson(string uri, string json)
        {
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = this.client.PostAsync(uri, content).Result;
            return result.Content.ReadAsStringAsync().Result;
        }

        protected string Put(string uri, List<KeyValuePair<string, string>> parameters)
        {
            var content = new FormUrlEncodedContent(parameters);
            var result = this.client.PutAsync(uri, content).Result;
            return result.Content.ReadAsStringAsync().Result;
        }

        protected string Delete(string uri)
        {
            var result = this.client.DeleteAsync(uri).Result;
            return result.Content.ReadAsStringAsync().Result;
        }
    }
    public class HttpParameters: List<KeyValuePair<string,string>>
    {
        public void Add(string key, string value)
        {
            this.Add(new KeyValuePair<string, string>(key, value));
        }

        public override string ToString()
        {
            var parameters = (from item in this
                              select string.Format("{0}={1}",
                              item.Key, item.Value));

            return "?" + string.Join("&", parameters);
        }

        public Dictionary<string, string> ToDictionary()
        {
            return this.ToDictionary(x => x.Key, x => x.Value);
        }

    }
}
