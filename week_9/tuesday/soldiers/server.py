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


