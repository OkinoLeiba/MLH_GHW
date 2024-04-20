using System;
using Stripe;




class RequestCustomer {
    
   public static void GetCustomerObject() {
        const string API_KEY = "";
        
   
        RequestOptions request_option = new RequestOptions{ApiKey=API_KEY};

        ChargeService service = new ChargeService((IStripeClient) request_option);

        Charge charge = service.Get("ch_3Ln3kB2eZvKYlo2C1YRBr0Ll"); 

        double amount = charge.Amount;
        string currency = charge.Currency;

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
