import mysql.connector

def get_connection():
    return mysql.connector.connect(
        host="localhost",
        port=3306,
        user="root",
        password="root",
        database="soldiers_db"
    )

def get_by_rank(rank) -> list :
    conn = get_connection()
    cursor =conn.cursor(dictionary=True)
    query = "SELECT * FROM soldiers WHERE srank = %s"
    cursor.execute(query,(rank,))
    soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return soldiers

def get_active_sorted_by_name(order="ASC"):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    if order not in ('ASC', 'DESC'):
        order = "ASC"
    query = f"SELECT * FROM soldiers WHERE active=TRUE ORDER BY name {order}"
    cursor.execute(query)
    sorted_soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return sorted_soldiers

def get_distinct_units()-> list:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT DISTINCT unit FROM soldiers"
    cursor.execute(query)
    distinct_units = cursor.fetchall()
    cursor.close()
    conn.close()
    return distinct_units

def search_by_name(term):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT * FROM soldiers WHERE name LIKE %s"
    cursor.execute(query,(f"%{term}%",))
    search_resalt = cursor.fetchall()
    cursor.close()
    conn.close()
    return search_resalt

def get_missing_rank():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT * FROM soldiers WHERE srank IS NULL"
    cursor.execute(query)
    soldiers_with_no_rank = cursor.fetchall()
    cursor.close()
    conn.close()
    return soldiers_with_no_rank

def get_by_unit(unit):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    query = "SELECT * FROM soldiers WHERE unit = %s ORDER BY name ASC"
    cursor.execute(query,(unit,))
    soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return soldiers