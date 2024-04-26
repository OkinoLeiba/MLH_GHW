using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;


namespace MLH {

class Request 

    {
        public static async Task<string> RequestCallApi(string apiKey) // add url parameter and apikey?

        {
            string url = "https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("APIKEY", apiKey);

            HttpResponseMessage responseMsg =  client.GetAsync(string.Format(url)).Result;

            string responseContent = await responseMsg.Content.ReadAsStringAsync();

            return responseContent;

            
        }
       
};
}