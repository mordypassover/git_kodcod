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

@app.get("/calc/{a}/{op}/{b}")
def calc(a:int, op:str, b:int):
    ops = {"add" : (lambda x,y : x + y), "sub": (lambda x,y : x - y),
           "molt":(lambda x,y : x * y) ,"div":lambda x,y : x /y}
    if op in ops:
        try:
            return {"operator": {op} ,"result": (ops[op](a, b))}
        except ZeroDivisionError as e:
            return {"operator":{op},"result":e.args[0]}
    else:
        return {"operator":{op},"result":"not sported operator"}


uvicorn.run(app)