from idlelib.query import Query

from fastapi import FastAPI, HTTPException
import uvicorn
import db_querys

app = FastAPI()

@app.get("/soldiers")
def get_query_param_and_send(rank=None, sort=None, unit=None):
    response = []
    if rank:
        response.append(db_querys.get_by_rank(rank))
    if sort:
        response.append(db_querys.get_active_sorted_by_name(sort))
    if unit:
        response.append(db_querys.get_by_unit(unit))
    if not response:
         response = db_querys.get_all()
    return response

@app.get("/soldiers/units")
def get_units():
    return db_querys.get_distinct_units()

@app.get("/soldiers/search")
def search_in_soldiers(term:str):
    return db_querys.search_by_name(term)

@app.get("/soldiers/missing-rank")
def get_soldiers_with_no_rank():
    return db_querys.get_missing_rank()