from fastapi import FastAPI
import uvicorn

app = FastAPI()

@app.get("/")
def service_and_version():
    return {f"service: my_api", "version: 1.0"}

@app.get("/users/admin")
def get_admin():
    return {"role": "admin", "access": "full"}

@app.get("/users/{user_id}")
def get_user_data(user_id):
    return {"user id ": user_id, "name": "", "email": ""}


uvicorn.run(app)