using System;
using DataTransferObjects.Extensions;
using Flurl.Http;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Properties;

namespace WinForms
{
    public class APIService
    {
        private readonly string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Settings.Default.APIUrl}/{_route}";
            try
            {
                if (search != null)
                    url += "?" + await search.ToQueryString();

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException err)
            {
                switch (err.Call.HttpStatus)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        MessageBox.Show(Resources.APIService___401_Status_code, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case System.Net.HttpStatusCode.Forbidden:
                        MessageBox.Show(Resources.APIService___403_Status_code, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case System.Net.HttpStatusCode.NotFound:
                        MessageBox.Show("Nije pronađen nijedan rezultat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(string id)
        {
            var url = $"{Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Settings.Default.APIUrl}/{_route}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }

        }

        public async Task<T> Update<T>(string id, object request)
        {
            var url = $"{Settings.Default.APIUrl}/{_route}/{id}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<HttpResponseMessage> Delete<T>(object id)
        {
            var url = $"{Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync();
        }

    }
}