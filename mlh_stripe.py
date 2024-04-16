import stripe, sys, os, json, requests, py_compile
from typing import Union, Optional, Any
from fastapi import FastAPI

sys.path.append('/anaconda3/Lib/site-packages')
sys.path.insert(0, '/anaconda3/Lib/site-packages')

py_compile.compile('mlh_stripe.py')

app = FastAPI()

def PullData(data_request: Optional[Any] = None) -> any:
    file = open('data.json')

    data = json.load(file)
    
    try:
        return data[data_request]
    except Exception:
        print("No value was passed to the function.")
    

global API_KEY

API_KEY = stripe.api_key = PullData('apiKey')
URL = 'https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json'
class MLH_Stripe:
    
    
    def RequestCall(url: Optional[str] = None) -> json:
        # r = requests.Request('GET', URL)
        header = {
           'Authorization' : API_KEY 
        }
        response = requests.get(url=URL, headers=header)
        # print(r)
        # print(response.json())
        return response.json()






    # stripe.app_info('stripe-samples/checkout-one-time-payments', version='0.0.1', url='https://github.com/stripe-samples/checkout-one-time-payments')

    # create customer data to [initial test data]
    def CreateCustomer() -> None:
        customer_options =  {
                #  'id'  :  "cus_NffrFeUfNV2Hib",
                'Address'  :  None,
                'Balance'  :  0,
                'CashBalance' : None,
                # 'created'  :  1680893993,
                #  'currency'  :  None,
                #  'default_source'  :  None,
                #  'delinquent'  :  False,
                'Description'  :  None,
                # 'discount'  :  None,
                 'Email'  :  "jennyrosen@example.com",
                #  'invoice_prefix'  :  "0759376C",
                'InvoiceSettings'  :  {
                     'CustomFields'  :  None,
                     'DefaultPaymentMethod'  :  None,
                     'Footer'  :  None,
                     'RenderingOptions'  :  None
                },
                #  'livemode'  :  False,
                'PaymentMethod' : "card",
                'Metadata'  :  {},
                'Name'  :  "Jenny Rosen",
                #  'next_invoice_sequence'  :  1,
                'Phone'  :  None,
                'Plan' : None,
                'PreferredLocales'  :  ["en-US"],
                'Shipping'  :  None,
                'TaxExempt'  :  None,
                'TestClock'  :  None
                }
        
        stripe.CustomerService.create(customer_options)

    # request customer data object from strip
    def RequestCustomer(id: Optional[str] = None) -> dict:

        return stripe.Charge.retrieve("ch_3Ln3e92eZvKYlo2C0eUfv7bi", api_key=API_KEY)

        # "ch_3Lmjoz2eZvKYlo2C1rBER4Dk",
        # stripe_account="acct_1032D82eZvKYlo2C"

if __name__ == '__main__':
    mlh_stripe = MLH_Stripe
    mlh_stripe.CreateCustomer()


    