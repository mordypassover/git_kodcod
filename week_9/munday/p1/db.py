import mysql.connector

def get_connection():
    return mysql.connector.connect(
    host="localhost",
    port=3306,
    user="root",
    password="root",
    database="soldiers_db"
    )


def get_all()->list:
    conn= get_connection()
    cursor=conn.cursor(dictionary=True)
    sql = "SELECT * FROM soldiers"
    cursor.execute(sql)
    all_soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return all_soldiers


def get_by_id(soldier_id: int) -> dict | None:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    sql = "SELECT * FROM soldiers WHERE id = %s"
    cursor.execute(sql, (soldier_id,))
    soldier = cursor.fetchone()

    cursor.close()
    conn.close()
    return soldier


def create_soldier(name: str , srank:str, unit: str)-> int:
    conn = get_connection()
    cursor = conn.cursor()
    sql = "INSERT INTO soldiers (name, srank, unit) VALUES (%s, %s, %s)"
    values_to_change = (name, srank, unit)
    cursor.execute(sql, values_to_change)
    conn.commit()

    new_id = cursor.lastrowid

    cursor.close()
    conn.close()
    return new_id

def update_soldier(soldier_id:int, data:dict ):
    conn = get_connection()
    cursor = conn.cursor()
    set_parts = [f"{key} = %s" for key in data.keys()]
    set_clause = ", ".join(set_parts)

    sql = "UPDATE soldiers SET " + set_clause +" WHERE id = %s"
    values = list(data.values()) + [soldier_id]

    cursor.execute(sql, values)
    conn.commit()

    changed_line = cursor.rowcount > 0
    cursor.close()
    conn.close()
    return changed_line
