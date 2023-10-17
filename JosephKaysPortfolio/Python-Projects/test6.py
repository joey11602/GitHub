import sqlite3
from sqlite3 import Error

#create a data base in RAM
def create_connection():
    conn = None
    try:
        conn = sqlite3.connect(':memory:')
        return conn
    except Error as e:
        print(e)

#create a table named Roster
def create_table(conn):
    try:
        c = conn.cursor()
        c.execute('''CREATE TABLE IF NOT EXISTS Roster(
            id INTEGER PRIMARY KEY, Name TEXT, Species TEXT,\
            IQ INTEGER)''')
    except Error as e:
        print(e)

#insert data into table
def insert_data(conn):
    try:
        c = conn.cursor()
        c.execute('INSERT INTO Roster (Name, Species, IQ) VALUES\
            ("Jean-Baptiste Zorg", "Human", 122)')
        c.execute('INSERT INTO Roster (Name, Species, IQ) VALUES\
            ("Korben Dallas", "Meat Popsicle", 100)')
        c.execute('INSERT INTO Roster (Name, Species, IQ) VALUES\
            ("Ak\'not", "Mangalore", -5)')
        conn.commit()
    except Error as e:
        print(e)

#update data
def update_data(conn):
    try:
        c = conn.cursor()
        c.execute('UPDATE Roster SET Species = "Human" WHERE\
            Name = "Korben Dallas"')
        conn.commit()
    except Error as e:
        print(e)
        
#print names and IQs of everyone in the table who is a human
def print_data(conn):
    try:
        c = conn.cursor()
        #select specific columns by criteria
        c.execute("SELECT Name, IQ FROM Roster WHERE Species = 'Human'") 
        rows = c.fetchall()
        #iterate through the rows
        for row in rows:
            name, iq = row
            print(f"{name} {iq}")
    except Error as e:
        print(e)    
#check for main and run       
if __name__ == '__main__':
    #create connection
    conn = create_connection()
    #create table
    create_table(conn)
    #insert data into table
    insert_data(conn)
    #update data in table
    update_data(conn)
    #print specified data
    print_data(conn)
    #close the connection
    if conn:
        conn.close()
