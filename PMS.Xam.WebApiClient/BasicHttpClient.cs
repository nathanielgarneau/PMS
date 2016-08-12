using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;
using PMS.Xam.WebApiClient.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class BasicHttpClient<T,TX> :  IApiClient<T,TX> where T : IEntity<TX>
    {
        public BasicHttpClient(string apiAddress)
        {
            ApiAddress = apiAddress;
        }
        private string ApiAddress { get; set; }
        private const string ManyAddress = "/Many";

        private void SetupHttpClient(HttpClient client)
        {
            client.BaseAddress = Config.BaseAddress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(Config.JsonHeaderValue);
        }
        private async Task<T> Get(TX id)
        {
            using (HttpClient client = new HttpClient())
            {
                SetupHttpClient(client);

                HttpResponseMessage response = await client.GetAsync(ApiAddress + "/" + id);
                if (response.IsSuccessStatusCode)
                {
                    T viewModel = await response.Content.ReadAsAsync<T>();
                    return viewModel;
                }
            }
            return default(T);
        }
        private async Task<IEnumerable<T>> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                SetupHttpClient(client);

                HttpResponseMessage response = await client.GetAsync(ApiAddress);
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<T> viewModels = await response.Content.ReadAsAsync<IEnumerable<T>>();
                    return viewModels;
                }
            }
            return default(IEnumerable<T>);
        }

        private async void Post(T viewModel)
        {
            using (var client = new HttpClient())
            {
                SetupHttpClient(client);

                MediaTypeFormatter formatter = new JsonMediaTypeFormatter();
                HttpResponseMessage response = await client.PostAsync(ApiAddress, viewModel, formatter);
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


                HttpResponseMessage response = await client.PutAsJsonAsync(ApiAddress, viewModel);
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
                request.Content = new ObjectContent(typeof(T),viewModel, new JsonMediaTypeFormatter());
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }

            }
        }

        private async Task<IEnumerable<T>> GetMany(params TX[] ids)
        {
            using (HttpClient client = new HttpClient())
            {
               SetupHttpClient(client);

                var request = new HttpRequestMessage(HttpMethod.Get, ApiAddress + ManyAddress)
                {
                    Content = new ObjectContent(typeof (TX[]), ids, new JsonMediaTypeFormatter())
                };
                var response = await client.SendAsync(request);
                //HttpResponseMessage response = await client.GetAsync(ApiAddress + ManyAddress);
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<T> viewModels = await response.Content.ReadAsAsync< IEnumerable<T>>();
                    return viewModels;
                }
            }
            return default(IEnumerable<T>);
        }
        private async void PostMany(params T[] viewModels)
        {
            using (var client = new HttpClient())
            {
               SetupHttpClient(client);

                MediaTypeFormatter formatter = new JsonMediaTypeFormatter();
                HttpResponseMessage response = await client.PostAsync(ApiAddress, viewModels, formatter);
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
                if (response.IsSuccessStatusCode)
                {
                    //Successful
                }

            }
        }

        public List<T> GetList(params TX[] ids)
        {
            var response = GetMany(ids);
            return response.Result.ToList();
        }

        public T  GetSingle(TX id)
        {
            var response = Get(id);
            return response.Result;
        }

        public List<T> GetAll()
        {
            var response = Get();
            return response.Result.ToList();
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
    }
}
