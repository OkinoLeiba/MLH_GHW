#!/usr/bin/env bash

test=$(curl "https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22")
echo $test
# curl -X POST 'https://accounts.spotify.com/api/token' -H 'Content-Type: application/x-www-form-urlencoded' -d 'grant-type=client_credentials&client_id={}&client_secert={}'

function RequestSpotifyData(){
    curl -X POST 'https://accounts.spotify.com/api/token'\
    -H 'Content-Type: application/x-www-form-urlencoded'\
    -d 'grant-type=client_credentials&client_id={}&client_secert={}'
}


function RequestSpotifyAlbum() {
    curl -request GET 'https://api.spotify.com/v1/albums/'${id}\
    --header 'Authorization: Bearer {}'
}


RequestSpotifyData