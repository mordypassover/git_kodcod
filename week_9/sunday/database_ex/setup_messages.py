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
