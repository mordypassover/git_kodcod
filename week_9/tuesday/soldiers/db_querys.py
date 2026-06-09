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

