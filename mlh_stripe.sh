#!/bin/bash

API_KEY="sk_test_51P2ITx08E6dS14v5umSelPiMlsmiRmUipXA4TAcQZfyXDx59M6qEU2ptPcGmzOsFab4UDxfGWcSaXqInfgOUqdoq00ybu4R8fY"

delecare -A request 

url="https://raw.githubusercontent.com/stripe-samples/test-data/master/customer-with-subscription/create-fixtures.json"

function resqest() {
    curl -X GET -H "Content-type: application/json" -H "Accept: application/json" -H "Authorization: ${API_KEY}"\
    $url >> request
}

function create_customer(){
    curl https://api.stripe.com/v1/customers -u "${API_KEY}:"
}