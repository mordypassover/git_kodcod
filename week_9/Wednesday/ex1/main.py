import uvicorn
from fastapi import FastAPI
import ex1


app = FastAPI()

@app.get("/stats/summary")
def get_summery():
    return ex1.get_summary()

@app.get("/stats/units")
def get_all_units():
    return ex1.count_by_unit()

@app.get("/stats/understaffed")
def get_understaffed():
    return ex1.get_units_with_multiple_soldiers()

@app.get("/soldiers/missing-rank")
def get_missing_rank():
    return ex1.get_missing_data()

if __name__ == "__main__":
    uvicorn.run(app="main:app", reload=True)