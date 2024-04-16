import requests, json, py_compile
from typing import Optional, Any
from fastapi import FastAPI

app = FastAPI()

# data = {
#     response_type: 'code',
#     client_id: client_id,
#     client_secret: 
#     scope: scope,
#     grant_type: authorization_code,
#     redirect_uri: redirect_uri,
#     state: state
# }



def RequestSpotifyData(request: Optional[Any] = None) -> json:
    # request = requests.get()
    file = open('data.json')

    data = json.load(file)

    spotify = data['Spotify']

    return spotify[request]

    



app.route('token', methods=['POST'])
def RequestSpotifyApiKey() -> str:
    URL = 'https://accounts.spotify.com/api/token'

    DATA = {
    'client_id': RequestSpotifyData('client_id'),
    'client_secret': RequestSpotifyData('client_secret'),
    'code': RequestSpotifyData('response_type'),
    # 'scope': 'scope',
    'grant_type': RequestSpotifyData('grant_type'),
    'redirect_uri': RequestSpotifyData('redirect_uri'),
    # 'state': 'state'
}

    response = requests.post(url=URL, data=DATA)

    API_KEY = response.dump()

    return "Access token saved."

if __name__ == '__main__':
    RequestSpotifyApiKey()



# var authOptions = {
 
#   headers: {
#     'Authorization': 'Basic ' + (new Buffer.from(client_id + ':' + client_secret).toString('base64'))
#   },
#   form: {
#     grant_type: 'client_credentials'
#   },
#   json: true
# };

# request.post(authOptions, function(error, response, body) {
#   if (!error && response.statusCode === 200) {
#     var token = body.access_token;
#   }
# });