from fastapi import FastAPI, HTTPException

app = FastAPI()
students = {"101": "Moshe", "102": "Yosef"}

@app.get("POST /students/{student_id}")
def check_student(student_id):
    if student_id in students:
        return students["students"]
    raise HTTPException(status_code=404 ,detail="id not found")