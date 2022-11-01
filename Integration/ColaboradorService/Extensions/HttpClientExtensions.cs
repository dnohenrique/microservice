using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ColaboradorService.Extensions
{
    public static class HttpClientExtension
    {
        public static async Task<HttpResponseMessage> PutAsJsonAsync<TInput>(this HttpClient client, string requestUri, TInput input) where TInput : class
        {
            var serialized = JsonConvert.SerializeObject(input);

            var httpContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponseMessage;

            try
            {
                httpResponseMessage = await client.PutAsync(requestUri, httpContent);

                if (!httpResponseMessage.IsSuccessStatusCode)
                {
                    var errorString = await httpResponseMessage.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<dynamic>(errorString);

                    throw new ApplicationException($"Requisição do cliente Http falhou com status {deserialized.Status} e erro {deserialized.ErrorCode}", deserialized);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Cliente Http falhou inesperadamente.", ex);
            }


            return httpResponseMessage;
        }

        public static async Task<TOutput> PostAsJsonAsync<TOutput, TInput>(this HttpClient client, string requestUri, TInput input)
            where TInput : class
            where TOutput : class

        {
            var responseMessage = await client.PutAsJsonAsync(requestUri, input);

            var responseString = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(responseString))
                responseString = JsonConvert.SerializeObject(new { Status = responseMessage.StatusCode.ToString() });

            return JsonConvert.DeserializeObject<TOutput>(responseString);
        }
    }
}
