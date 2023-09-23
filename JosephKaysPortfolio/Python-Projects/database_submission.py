#this will import the sqlite3 module
import sqlite3
    
#establishe a connection to a SQlite database file or create a new one if it doesn't exist
conn = sqlite3.connect('test2.db')

#the with statement block is to ensure proper cleanup of resources
with conn:
    
    #create a cursor object to interact with the database
    cursor = conn.cursor()
    
    #create a table called 'tbl_files' with an ID/Primary key column and a col_file column
    cursor.execute('CREATE TABLE IF NOT EXISTS tbl_files(ID INTEGER PRIMARY KEY AUTOINCREMENT, \
    col_file TEXT)')
    
    #commit the changes
    conn.commit()

#this is a tuple that my script will sort through to insert into the data base
fileList = ('information.docx', 'Hello.txt', 'myImage.png', 'myMovie.mpg', 'World.txt', \
            'data.pdf', 'myPhoto.jpg')

#define a variable for a list to be used to store the txt file names
txtFileNames = []

#iterate through the tuple 'fileList' and append the .txt file names to my list
for file in fileList:
    if file.endswith('.txt'):
        txtFileNames.append(file)

#the with statement block is to ensure proper cleanup of resources
with conn:
    
    #create a cursor object to interact with the database
    cursor = conn.cursor()
    
    #using a for loop to insert each txt file name into the data base
    for File in txtFileNames: 
        cursor.execute(f'INSERT INTO tbl_files(col_file) VALUES (?)', (File,))

        #commit the changes
        conn.commit()

#the with statement block is to ensure proper cleanup of resources
with conn:
    
    #create a cursor object to interact with the database
    cursor = conn.cursor()

    #query data from table
    cursor.execute('SELECT ID, col_file FROM tbl_files')
    allFiles = cursor.fetchall()
    for element in allFiles:
        #print to the console
        print(f'ID: {element[0]}, File Name: {element[1]}')
    
#close the cursor and the connection
cursor.close()
conn.close() 
    
        


    
   
