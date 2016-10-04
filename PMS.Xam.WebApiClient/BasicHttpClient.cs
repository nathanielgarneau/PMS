using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;
using PMS.Xam.WebApiClient.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class BasicHttpClient<T, TX> : IApiClient<T, TX> where T : IEntity<TX>
    {
        private const string ManyAddress = "/Many";

        public BasicHttpClient(string apiAddress)
        {
            ApiAddress = apiAddress;
        }

        private string ApiAddress { get; }

        public List<T> GetList(params TX[] ids)
        {
            var response = GetMany(ids);
            return response.Result != null ? response.Result.ToList() : new List<T>();
        }

        public T GetSingle(TX id)
        {
            var response = Get(id);
            return response.Result;
        }

        public List<T> GetAll()
        {
            var response = Get();
            return response.Result != null ? response.Result.ToList() : new List<T>();
        }

        public void Add(params T[] items)
        {
            PostMany(items);
        }

        public void Add(T item)
        {
            Post(item);
        }

        public void Update(params T[] items)
        {
            PutMany(items);
        }

        public void Update(T item)
        {
            Put(item);
        }

        public void Remove(params T[] items)
        {
            DeleteMany(items);
        }

        public void Remove(T item)
        {
            Delete(item);
        }

        private void SetupHttpClient(HttpClient client)
        {
            client.BaseAddress = Config.BaseAddress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(Config.JsonHeaderValue);
        }

        private async Task<T> Get(TX id)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                var response = await client.GetAsync(ApiAddress + "/" + id);
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode) return default(T);

                var viewModel = await response.Content.ReadAsAsync<T>();
                return viewModel;
            }
        }

        private async Task<IEnumerable<T>> Get()
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                var response = await client.GetAsync(ApiAddress);
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode) return default(IEnumerable<T>);

                var viewModels = await response.Content.ReadAsAsync<IEnumerable<T>>();
                return viewModels;
            }
        }

        private async void Post(T viewModel)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                MediaTypeFormatter formatter = new JsonMediaTypeFormatter();

                var response = await client.PostAsync(ApiAddress, viewModel, formatter);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }

        private async void Put(T viewModel)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);


                var response = await client.PutAsJsonAsync(ApiAddress + "/" + viewModel.Id, viewModel);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }

        private async void Delete(T viewModel)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);


                var request = new HttpRequestMessage(HttpMethod.Delete, ApiAddress);
                request.Content = new ObjectContent(typeof (T), viewModel, new JsonMediaTypeFormatter());
                var response = await client.DeleteAsync(ApiAddress + "/" + viewModel.Id);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }

        private async Task<IEnumerable<T>> GetMany(params TX[] ids)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);
                var parameters = new List<KeyValuePair<string, object>>();
                if (ids.Any())
                {
                    parameters.AddRange(ids.Select(id => new KeyValuePair<string, object>("ids", id)));
                }
                var request = new HttpRequestMessage(HttpMethod.Get,
                    ApiAddress + ManyAddress + AsQueryString(parameters));

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode) return default(IEnumerable<T>);

                var viewModels = await response.Content.ReadAsAsync<IEnumerable<T>>();
                return viewModels;
            }
        }

        public string AsQueryString(IEnumerable<KeyValuePair<string, object>> parameters)
        {
            if (!parameters.Any())
                return "";

            var builder = new StringBuilder("?");

            var separator = "";
            foreach (var kvp in parameters.Where(kvp => kvp.Value != null))
            {
                builder.AppendFormat("{0}{1}={2}", separator, WebUtility.UrlEncode(kvp.Key),
                    WebUtility.UrlEncode(kvp.Value.ToString()));

                separator = "&";
            }

            return builder.ToString();
        }

        private async void PostMany(params T[] viewModels)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                MediaTypeFormatter formatter = new JsonMediaTypeFormatter();
                var response = await client.PostAsync(ApiAddress, viewModels, formatter);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }

        private async void PutMany(params T[] viewModels)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);


                var response = await client.PutAsJsonAsync(ApiAddress, viewModels);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }

        private async void DeleteMany(params T[] viewModels)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                var request = new HttpRequestMessage(HttpMethod.Delete, ApiAddress)
                {
                    Content = new ObjectContent(typeof (IEnumerable<T>), viewModels, new JsonMediaTypeFormatter())
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }
            }
        }
    }
}