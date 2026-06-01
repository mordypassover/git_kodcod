import requests
def safe_get(url):
    request = requests.get(url)
    s_code = request.status_code
    if s_code == 200:
        return request.json()

    elif s_code == 404:
        return None

    else:
        raise Exception(f"status code = {s_code}")
