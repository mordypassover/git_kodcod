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
