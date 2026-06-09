import mysql.connector


def get_connection():
    return mysql.connector.connect(
    host="localhost",
    port=3306,
    user="root",
    password="root",
    database="soldiers_db"
    )


def create_schema():
    conn = get_connection()
    cursor = conn.cursor()
    create_table_sql="""
    CREATE TABLE IF NOT EXISTS intel_messages (
    id INT AUTO_INCREMENT PRIMARY KEY,
    unit VARCHAR(100) NOT NULL,
    classification ENUM('unclassified','confidential','secret','top_secret'),
    content TEXT NOT NULL,
    source VARCHAR(100),
    created_at DATETIME DEFAULT NOW() )
    """
    cursor.execute(create_table_sql)
    conn.commit()
    cursor.close()
    conn.close()
    return "table created successfully"


def get_schema() -> list:
    conn = get_connection()
    cursor = conn.cursor()
    cursor.execute("DESCRIBE soldiers")
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return [{"column": row[0], "type": row[1]} for row in rows]


def get_1_message(msg_id):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    sql = "SELECT * FROM intel_messages WHERE id = %s"
    cursor.execute(sql, (msg_id,))
    message =cursor.fetchone()
    cursor.close()
    conn.close()
    return message


def create_message(unit: str, classification: str, content: str, source:str | None) -> int:
    conn = get_connection()
    cursor = conn.cursor()
    sql = "INSERT INTO intel_messages (unit, classification, content,  source) VALUES (%S, %S, %S, %S )"
    values = (unit, classification, content, source)
    cursor.execute(sql, values)
    conn.commit()
    new_id = cursor.lastrowid
    cursor.close()
    conn.close()
    return new_id

def update_message(message_id: int, data: dict):
    conn = get_connection()
    cursor = conn.cursor()
    data_list = [f"{d_key} = s%" for d_key in data]


