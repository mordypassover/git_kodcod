from fastapi import FastAPI
import uvicorn

grades = {
    "1": {"name": "Moshe", "grade": 88},
    "2": {"name": "Yaakov", "grade": 75},
    "3": {"name": "David", "grade": 92},
    }

app =FastAPI()
@app.get("/students")
def get_all_students():
    return grades

@app.get("/students/top")
def top_student():
    top_student_id = max(grades, key = lambda k:grades[k]["grade"])
    return {"best student":top_student_id}

@app.get("/students/average")
def get_avg():
    return {"avg":(sum(grades[i]["grade"] for i in grades) / len(grades))}

@app.get("/students/count")
def get_sum_of_students():
    return {"student sum": len(grades)}

@app.get("/students/{student_id}")
def get_student(student_id):
    if student_id in grades:
        return grades[student_id]
    else:
        return {"status":"student not found"}

uvicorn.run(app)
