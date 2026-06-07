from fastapi import FastAPI, HTTPException
import uvicorn
import setup_messages

app = FastAPI()

@app.post("/soldiers-db",status_code=201)
def create_intel_messages():
    return setup_messages.create_schema()

@app.get("/soldiers-db/{table_name}")
def get_schema_by_name(table_name:str):
    try:
        return setup_messages.get_a_schema(table_name)
    except Exception as e:
        raise HTTPException(status_code=404, detail={e:"table not found"})

@app.get("/messages")
def get_messages():
    return {"messages": []}

if __name__ == "__main__":
    uvicorn.run(app)