import db
from fastapi import FastAPI, HTTPException
import uvicorn

app = FastAPI()

@app.get("/soldiers")
def get_all_soldiers():
    return db.get_all()

@app.get("/soldiers/{id}")
def get_soldier_via_id(soldier_id):
    soldier = db.get_by_id(soldier_id)
    if not soldier:
        raise HTTPException(status_code=404, detail="soldier not in data table")
    return soldier
