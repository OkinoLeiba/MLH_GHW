using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace MLH {

class Request 

    {
        public static async Task<string> RequestCallApi() // add url parameter and apikey?

        {
            string url = "https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMsg =  client.GetAsync(string.Format(url)).Result;

            string responseContent = await responseMsg.Content.ReadAsStringAsync();

            return responseContent;

            
        }
       
};
}