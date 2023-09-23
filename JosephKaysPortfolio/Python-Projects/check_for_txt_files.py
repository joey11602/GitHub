# import the os module
import os

# assign a variable for my absolute file path
dirP = 'C:\\Users\\joey3\\OneDrive\\Documents\\Tech Academy'

# assign a variable to an empty list to store file names
listFileNames = []

# os.listdir() will be used to get a list of files and directories in the specified directory
for fileName in os.listdir(dirP):
    #use os.path.isfile() and .endswith() to check if the item is a file and not a directory and ends with the .txt extension
    if os.path.isfile(os.path.join(dirP, fileName)) and fileName.endswith('.txt'):
        # append the true .txt file name to the list
        listFileNames.append(fileName)

# print the list of .txt file names
if listFileNames:
    print("List of .txt files:\n")
    for i, listFileNames  in enumerate(listFileNames, start=1):
        print(f"{i}. {listFileNames}")
# this else statement will display that there are no .txt files if that is the case
else:
    print("No .txt files found in the directory.")
    

