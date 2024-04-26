// dotnet add package Strip.net
// dotnet restore 

using System;
using Stripe;






class CreateCustomer {

        public static void CustomerCreateFunc() {
        const string API_KEY = IAPIKEY.API_KEY;
        // "sk_test_51P2ITx08E6dS14v5umSelPiMlsmiRmUipXA4TAcQZfyXDx59M6qEU2ptPcGmzOsFab4UDxfGWcSaXqInfgOUqdoq00ybu4R8fY";

        // static stripe = new Stripe.StripeConfiguration;
        
        // Stripe.StripeConfiguration.ApiKey RGetApiKey(string apiKey = API_KEY)

        // review, refactor add to Get method
        Stripe.RequestOptions options = new Stripe.RequestOptions{ApiKey=API_KEY};

        Stripe.CustomerCreateOptions customer_option = new Stripe.CustomerCreateOptions
            {
                //  id  =  "cus_NffrFeUfNV2Hib",
                Address  =  null,
                Balance  =  0,
                CashBalance = null,
                // created  =  1680893993,
                //  currency  =  null,
                //  default_source  =  null,
                //  delinquent  =  false,
                Description  =  null,
                // discount  =  null,
                 Email  =  "jennyrosen@example.com",
                //  invoice_prefix  =  "0759376C",
                InvoiceSettings  =  {
                     CustomFields  =  null,
                     DefaultPaymentMethod  =  null,
                     Footer  =  null,
                     RenderingOptions  =  null
                },
                //  livemode  =  false,
                PaymentMethod = "card",
                Metadata  =  {},
                Name  =  "Jenny Rosen",
                //  next_invoice_sequence  =  1,
                Phone  =  null,
                Plan = null,
                PreferredLocales  =  ["en-US"],
                Shipping  =  null,
                TaxExempt  =  "none",
                TestClock  =  null
                };
        


        ChargeService service = new ChargeService((IStripeClient) options);

        CustomerService customerService = new CustomerService();

        Customer customer = customerService.Create(customer_option);

   
        // static Charge charge = service.Get("ch_3Ln3kB2eZvKYlo2C1YRBr0Ll"); 

        // double amount = charge.Amount;
        // string currency = charge.Currency;

    // try {} catch (StripeException e) {
    //     switch (e.StripeError.Type)
    //     {
    //         case "carderror":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "api_connection_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "api_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "authentication_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "invalid_request_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "rate_limit_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         case "validation_error":
    //             Console.WriteLine("Error Code " + e.StripeError.Code);
    //             Console.WriteLine("Error Message " + e.StripeError.Message);
    //             break;
    //         default:
    //             // Unknown Error Type
    //             Console.WriteLine("Unknown Error");
    //             break;
            
    //     };

    // };
        }

};





