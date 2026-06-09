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