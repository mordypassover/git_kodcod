import db
from fastapi import FastAPI, HTTPException
import uvicorn

app = FastAPI()

@app.get("/soldiers")
def get_all_soldiers():
    return db.get_all()

@app.get("/soldiers/{id}")
def get_soldier_via_id(soldier_id:int):
    soldier = db.get_by_id(soldier_id)
    if not soldier:
        raise HTTPException(status_code=404, detail="soldier not in data table")
    return soldier

@app.post("/soldiers",status_code=201)
def create_new_soldier(soldier_data:dict):
    name = soldier_data["name"]
    srank = soldier_data["srank"]
    unit = soldier_data["unit"]
    new_id = db.create_soldier(name, srank, unit)
    return {"new soldiers id": new_id}

