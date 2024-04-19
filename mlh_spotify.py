import requests, os, json, py_compile, string, base64
from typing import Optional,Union, Any
from random import choices
from hashlib import md5
from fastapi import FastAPI

app = FastAPI(root_path='https://api.spotify.com')



# data = {
#     response_type: 'code',
#     client_id: client_id,
#     client_secret: 
#     scope: scope,
#     grant_type: authorization_code,
#     redirect_uri: redirect_uri,
#     state: state
# }


app.route('/data.json')
def RequestSpotifyData(request: Optional[Any] = None) -> json:
    # request = requests.get()
    file = open('data.json')

    data = json.load(file)

    spotify = data['Spotify']

    return spotify[request]

    



app.route('/api/token', methods=['POST'])
def RequestSpotifyApiKey() -> str:
    global ACCESS_TOKEN
    URL = 'https://accounts.spotify.com/api/token'

    random_hash = ''.join(choices(string.ascii_lowercase + string.ascii_lowercase + string.digits, k=16))

    hash = md5(os.urandom(128)).hexdigest()[:16]


    DATA = {
    "client_id": RequestSpotifyData('client_id'),
    "client_secret": RequestSpotifyData('client_secret'),
    # "code": RequestSpotifyData('response_type'),
    # "scope": RequestSpotifyData('scope')['open_access'][0],
    "grant_type": RequestSpotifyData('grant_type')[1],
    "redirect_uri": RequestSpotifyData('redirect_uri'),
    "state": hash
}

    response = requests.post(url=URL, data=DATA)

    response_data = response.json()

    ACCESS_TOKEN = response_data['access_token']

    return ACCESS_TOKEN

app.route(path='/v1/albums', methods=['GET'])
def RequestSpotifyAlbum(id: Optional[str] = None) -> json:

    URL = f"https://api.spotify.com/v1/albums?ids={id}"

    HEADERS = {
        "Authorization": f"Bearer {ACCESS_TOKEN}"
    }

    response = requests.get(url=URL, headers=HEADERS)

    response_data = response.json()

    if response_data == None:
        print('Album not found, please ensure album name is correct.')
    else:
        return response_data


app.route(path='/albums', methods=['GET'])
def RequestSpotifyAlbums(ids: Optional[Union[str | list]]) -> json:
    URL = 'https://api.spotify.com/v1/albums?ids='

    url_param = ''
    for index,id in enumerate(ids):
        if index == 0:
            url_param += ''.join(id)
        else:
            url_param += ''.join('%' + id)

    HEADERS = {
        "Authorization": f"Bearer {ACCESS_TOKEN}"
    }

    response = requests.get(url=URL, headers=HEADERS)

    response_data = response.json()

    if response_data == None or response_data['error']['status'] == 400:
        print('Albums not found, please ensure album name is correct.')
    else:
        return response_data
    

app.route(path='/v1/albums', methods=['Delete'])
def DeleteSpotifyAlbum(ids: Optional[Union[str | list]]) -> None:
    URL = 'https://api.spotify.com/v1/albums?ids='
    
    url_param = ''
    for index,id in enumerate(ids):
        if index == 0:
            url_param += ''.join(id)
        else:
            url_param += ''.join('%' + id)

    HEADERS = {
        "Authorization": f"Bearer {ACCESS_TOKEN}",
        'Content-Type': "application/json"
    }

    response = requests.delete(url=URL+url_param, data=ids, headers=HEADERS,)

    response_data = response.json()

    if len(ids) == 0:
        return 'Album has been successfully deleted.'
    else:
        return 'Albums has been successfully deleted.'
    
    

app.route('/browse/new-releases', methods=['GET'])
def GetNewReleases() -> dict:
    URL = 'https://api.spotify.com/v1/browse/new-releases'

    HEADERS = {
        "Authorization": f"Bearer {ACCESS_TOKEN}"
    }

    response = requests.get(url=URL, headers=HEADERS)

    response_data = response.json()

    return response_data['albums']['items']




if __name__ == '__main__':
    app.__init__(on_startup=RequestSpotifyApiKey())
    RequestSpotifyAlbum('4aawyAB9vmqN3uQ7FjRGTy')
    RequestSpotifyAlbums(['82ObEPsp2rxGrnsizN5TX','2C1A2GTWGtFfWp7KSQTwWOyo','2C2noRn2Aes5aoNVsU6iWThc'])
    GetNewReleases()
    



