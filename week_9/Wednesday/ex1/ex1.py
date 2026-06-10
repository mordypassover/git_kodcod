import mysql.connector

def get_conn():
    return mysql.connector.connect(
        host="localhost",
        port=3306,
        user="root",
        password="root",
        database="soldiers_db")

def get_summary():
    conn = get_conn()
    cursor = conn.cursor(dictionary=True)
    query= "SELECT COUNT(*) AS all_soldiers FROM soldiers"
    cursor.execute(query)
    all_soldiers = cursor.fetchone()["all_soldiers"]
    query = "SELECT COUNT(*) AS active FROM soldiers Where active = TRUE"
    cursor.execute(query)
    active_soldiers = cursor.fetchone()["active"]
    cursor.close()
    conn.close()
    return {"total": all_soldiers, "active": active_soldiers, "inactive": all_soldiers - active_soldiers}

def count_by_unit() -> list:
    conn = get_conn()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT unit, COUNT(*) AS total FROM soldiers GROUP BY unit ORDER BY total DESC"
    cursor.execute(query)
    unit_count = cursor.fetchall()

    cursor.close()
    conn.close()
    return unit_count

def get_missing_data():
    conn = get_conn()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT * FROM soldiers WHERE srank IS NULL"
    cursor.execute(query)
    no_rank = cursor.fetchall()
    cursor.close()
    conn.close()
    return no_rank

def get_units_with_multiple_soldiers():
    conn = get_conn()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT unit, COUNT(*) AS total FROM soldiers GROUP BY unit HAVING total > 1"
    cursor.execute(query)
    more_then_1_in_unit = cursor.fetchall()
    cursor.close()
    conn.close()
    return more_then_1_in_unit
