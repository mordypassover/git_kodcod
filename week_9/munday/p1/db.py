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