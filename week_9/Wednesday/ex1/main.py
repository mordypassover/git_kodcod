import uvicorn
from fastapi import FastAPI
import ex1
import reports

app = FastAPI()

@app.get("/stats/summary")
def get_summery():
    return ex1.get_summary()

