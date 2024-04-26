dotnet add package Strip.net
dotnet restore 

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collection.Generic;

const API_KEY = StripeConfiguration.API_KEY = MLH_CSharp.IAPIKEY

"sk_test_51P2ITx08E6dS14v5umSelPiMlsmiRmUipXA4TAcQZfyXDx59M6qEU2ptPcGmzOsFab4UDxfGWcSaXqInfgOUqdoq00ybu4R8fY";

var options = RequestOption{ApiKey=API_KEY}

var services = new ChargeServices();

services.ChargeServices(options)


class Request 

{
    static async string RequestCallApi(string apiKey) 

    {
        string url = $'https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json'

        client = new HttpClient();

        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue('application/json'));

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("APIKEY", apiKey);

        HttpResponseMessage responseMsg =  await client.GetAsync(string.Format(url)).Add

        return responseContent = await responseContent.Content.ReadAsStringAsync();
        
    }
}



