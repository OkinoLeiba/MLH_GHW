#!/bin/bash

API_KEY="sk_test_51P2ITx08E6dS14v5umSelPiMlsmiRmUipXA4TAcQZfyXDx59M6qEU2ptPcGmzOsFab4UDxfGWcSaXqInfgOUqdoq00ybu4R8fY"
name=""
email=""

declare -A request 

url="https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json"

function request() {
    curl -X GET ${url} -H "Content-type: application/json" -H "Accept: application/json" -H "Authorization: ${API_KEY}"\
    $url >> request.txt
}

function create_customer($name, $email){
    curl https://api.stripe.com/v1/customers -u "${API_KEY}" -d "name=${name}" --data-urlencode "email=$email"
}

function customer_list($customer) {
    curl -G https://api.stripe.com/v1/customers -u "sk_test_QUXcoU3BnbZXp6IMVi7BkW8s:" -d "limit=3"
}

request
create_customer()