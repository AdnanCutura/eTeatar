
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects.Extensions;
using Flurl.Http;
using Xamarin.Forms;

namespace XamarinForms
{
    public class APIService
    {
        private readonly string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }

#if DEBUG
        private readonly string _apiUrl = "http://localhost:10264/api";
#endif
#if RELEASE
        private readonly string _apiUrl = "https://mywebsite.com/api";
#endif
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";
            try
            {
                if (search?.ToKeyValue() != null)
                    url += "?" + await search.ToQueryString();

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException err)
            {
                switch (err.Call.HttpStatus)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                        break;
                    case System.Net.HttpStatusCode.Forbidden:
                        await Application.Current.MainPage.DisplayAlert("Greška", "Niste autorizirani", "OK");
                        break;
                    case System.Net.HttpStatusCode.NotFound:
                        await Application.Current.MainPage.DisplayAlert("Informacija", "Nije pronaden nijedan rezultat", "OK");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(string id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException err)
            {
                var errors = await err.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default;
            }

        }

        public async Task<T> Update<T>(string id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");

                return default;
            }
        }

        public async Task<HttpResponseMessage> Delete<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync();
        }

    }
}
