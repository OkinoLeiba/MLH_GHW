// dotnet add package Strip.net
// dotnet restore 

using System;
using System.Security.Cryptography.X509Certificates;
using Stripe;






class CreateCustomer {

        public static void CustomerCreateFunc() {
        const string API_KEY = IAPIKEY.API_KEY;

        // public string address;
        const object customer_params = new Object {
            public string? address;
            public int? balance;
            public string? cashBalance;
            public string? currency;
            // public string? default_source;
            // public bool? delinquent  =  false,
            public string? description;
            // public string? discount;
            public string? email;
                    //  invoice_prefix  =  "0759376C",
            public object? nvoiceSettings =  {
                                public string? customFields;
                                public string? defaultPaymentMethod;
                                public string? footer;
                                public string? renderingOptions;};
            // public bool? livemode  =  false,
            public string? paymentMethod;
            public object? metadata = new {};
            public string? name;
            //  public int? next_invoice_sequence  =  1,
            public string? phone;
            public string? plan;
            public string? preferredLocales = Array;
            public string? shipping;
            public string? taxExempt = "none";
            public string? testClock;
        };
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

        Stripe.CustomerCreateOptions customer_option = new Stripe.CustomerCreateOptions {
            address = customer_params?.address,
            balance = customer_params.balance || null,
            currency = customer_params.currency || null,
            cashBalance = customer_params.cashBalance || null,
            default_source = customer_params.defaultSource || null,
            description = customer_params.description || null,
            discount = customer_params.discount || null,
            email = customer_params.email || null,
            invoiceSettings = customer_params.invoiceSettings || {},
            metadata = customer_params.metadata || {},
            name = customer_params.name || null,
            phone = customer_params.phone || null,
            plan = customer_params.plan || null,
            preferred_locales = customer_params.preferredLocales || [],
            shipping = customer_params.shipping || null,
            tax_exempt = customer_params.taxExempt || 'none',
            test_clock = customer_params.testClock || null
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





