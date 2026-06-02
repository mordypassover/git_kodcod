import requests

all_posts = requests.get("https://jsonplaceholder.typicode.com/posts")
all_users = requests.get("https://jsonplaceholder.typicode.com/users")

