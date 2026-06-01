from fastapi import FastAPI
import uvicorn

app = FastAPI()

@app.get("/ping")
def pong():
    return {"stat":"pong"}

@app.get("/ping/{name}")
def great(name):
    return {f"great {name}":f"hello {name}"}

uvicorn.run(app)