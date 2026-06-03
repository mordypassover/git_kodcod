from fastapi import FastAPI, HTTPException

app = FastAPI()

@app.get("/numbers/{n}")
def check_positive(n):
    if n < 0:
        raise HTTPException(status_code=400,
                            detail={"error": "number is negative"})
    return n