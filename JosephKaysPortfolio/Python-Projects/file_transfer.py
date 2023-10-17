#------------------------------------------------------------------------------------------

#import all necessary modules
import tkinter as tk
from tkinter import *
import tkinter.filedialog
import os
import shutil
import time

#-----------------------------------------------------------------------------------------

#create a custom class from the tkinter class 'Frame'
class ParentWindow(Frame):
    def __init__(self,master):
        Frame.__init__(self)
        
        #gives the GUI a title "File Transfer"
        self.master.title("File Transfer")
        
        #create a button to select which files to transfer as the source
        self.sourceDir_btn = Button(text="Select Source", width=20, command=self.sourceDir)
        
        #position the source button using grid()
        self.sourceDir_btn.grid(row=0, column=0, padx=(20, 10), pady=(30, 0))
        
        #create a entry field for the source directory selection
        self.source_dir = Entry(width=75)
        
        #position the entry field using grid() and the same padx and pady values so they line up
        self.source_dir.grid(row=0, column=1, columnspan=2, padx=(20, 10), pady=(30, 0))
        
        #create a button to select where the files are transfered to
        self.destDir_btn = Button(text="Select Destination", width=20, command=self.destDir)
        
        #position the destination button using grid() on the next row
        self.destDir_btn.grid(row=1, column=0, padx=(20, 10), pady=(15, 10))
        
        #create a entry field for the destination directory selection
        self.destination_dir = Entry(width=75)
        
        #position the entry field using grid() and the same padx and pady values so they line up
        self.destination_dir.grid(row=1, column=1, columnspan=2, padx=(20, 10), pady=(15, 10))
        
        #create a button to transfer files
        self.transfer_btn = Button(text="Transfer Files", width=20, command=self.transferFiles)
        
        #position the transfer files button
        self.transfer_btn.grid(row=2, column=1, padx=(200, 0), pady=(0, 15))
        
        #create a exit button
        self.exit_btn = Button(text="Exit", width=20, command=self.exit_program)
        
        #positions the exit button
        self.exit_btn.grid(row=2, column=2, padx=(10, 40), pady=(0, 15))

#-------------------------------------------------------------------------------------------------
        
    #create a function that selects the source directory to be transferred
    def sourceDir(self):
        
        #opens the dialog box to select the source directory
        selectSourceDir = tkinter.filedialog.askdirectory()
        
        #clears the contents of the entry box 
        self.source_dir.delete(0, END)
        
        #inserts the selected directory in the entry box
        self.source_dir.insert(0, selectSourceDir)

#--------------------------------------------------------------------------------------------------
        
    #create a function to select the destination directory
    def destDir(self):
        
        #opens a dialog box to select the destination directory
        selectDestDir = tkinter.filedialog.askdirectory()

        #clears the contents of the entry box
        self.destination_dir.delete(0, END)
        
        #inserts the selected directory in the entry box
        self.destination_dir.insert(0, selectDestDir)

#--------------------------------------------------------------------------------------------------
        
    #create a function to transfer the files from source to destination
    def transferFiles(self):
        
        #gets the source directory
        source = self.source_dir.get()
        
        #gets the destination directory
        destination = self.destination_dir.get()
        
        #gets a list of files in the source directory
        source_files = os.listdir(source)
        
        #gets the current time in seconds since the epoch
        current_time = time.time()
        
        #formula for 24 hours in seconds
        twenty_four_hours = 24 * 60 * 60
        
        #iterates through each file from the source directory
        for file in source_files:
            
            #create a complete file path to be used with the getmtime()
            file_path = os.path.join(source, file)
            
            #gets the time of the last modification of the file since epoch 
            modified_time = os.path.getmtime(file_path)
            
            #this calculates the time difference between the current time and the modification time
            time_difference = current_time - modified_time
            
            #this if/else statement checks to see if the file has been modified within the last 24 hours
            #it then prints the appropriate statement according to the expression
            if time_difference <= twenty_four_hours:
                shutil.move(file_path, destination)
                print(f"{file} was successfully transferred.")
            else:
                print(f"{file} was not modified within the last 24 hours and will not be transferred.")

#------------------------------------------------------------------------------------------------------
                
    #create a function to exit the program
    def exit_program(self):
        
        #This terminates the main loop in the program
        root.destroy()

#------------------------------------------------------------------------------------------------------
        
#check if running directly
if __name__ == "__main__":
    
    #create a intance of the Tk class
    root = tk.Tk()
    
    #create a instance of ParentWindow class and pass root as the parent  for this instance
    App = ParentWindow(root)
    
    #starts the mainloop which listens for events so the GUI can respond to the user
    root.mainloop()

        
