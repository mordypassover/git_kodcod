from fastapi import FastAPI
import uvicorn
import setup_messages

app = FastAPI()

@app.post("/soldiers-db",status_code=201)
def create_intel_messages():
    return setup_messages.create_schema()

@app.get("/soldiers-db/{table_name}")
def get_schema_by_name(table_name:str):
    return setup_messages.get_a_schema(table_name)
