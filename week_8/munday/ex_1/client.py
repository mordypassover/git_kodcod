import requests
def get_name_email_city():
    request1 = requests.get("https://jsonplaceholder.typicode.com/users/1")
    print(f"Name:  {request1.json()["name"]},"
          f" \nEmail: {request1.json()["email"]},"
          f" \nCity: {request1.json()["address"]["city"]}")
get_name_email_city()


request2 = requests.get("https://jsonplaceholder.typicode.com/posts")
print(len(request2.json()))

request3 = requests.get("https://jsonplaceholder.typicode.com/posts/?userId=2")
for post in request3.json():
    print(post["title"])