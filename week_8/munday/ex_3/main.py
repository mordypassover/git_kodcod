import uvicorn
from fastapi import FastAPI

app = FastAPI()
@app.get("/greet")
def greet(name="we",):
    return {"message" : f"hello {name}"}


uvicorn.run(app)
