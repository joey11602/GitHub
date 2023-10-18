#---------------------------------------------------------------------

#import necessary modules into Python
import tkinter as tk
from tkinter import *
import webbrowser

#---------------------------------------------------------------------

#create a custom class from the tkinter class 'Frame'
class ParentWindow(Frame):
    #initialize ParentWindow with self and master as the parameters
    def __init__(self,master):
        #initialize the inherited properties/methods from 'Frame' class
        Frame.__init__(self)

        #gives the GUI a title "File Transfer"
        self.master.title("Web Page Generator")

        #create a label for the entry field
        self.lbl_cust_text = Label(self.master,text=\
        "Enter custom text or click the Default HTML Page button",\
        font=('Helvetica', 16), fg='black')

        #position the label using grid()
        self.lbl_cust_text.grid(row=0, column=0, columnspan=2,\
        padx=(0,670), pady=(10,10))

        #create an entry field for the custom text
        self.cust_text = Entry(width=150)

        #position the entry field using grid()
        self.cust_text.grid(row=1, column=0, columnspan=2,\
        padx=(20,20), pady=(10,10))

        #create a button for default html page
        self.btn = Button(self.master, text="Default HTML Page",\
        width=30, height=2, command=self.defaultHTML)
        
        #position the default html page button using grid()
        self.btn.grid(row=2, column=1, padx=(400,0), pady=(10,10))

        #create a button for custom text html page
        self.cust_btn = Button(self.master,\
        text="Submit Custom Text", width=30, height=2,\
        command=self.customHTML)

        #position the submit custom text button using grid()
        self.cust_btn.grid(row=2, column=1, padx=(960,20),\
        pady=(10,10))

#---------------------------------------------------------------------
        
    #this function will create a default html page
    def defaultHTML(self):
        
        #create string variable with the default content
        htmlText = "Stay tuned for our amazing summer sale!"
        
        #**************************************************************
        #this will open the file named 'index.html or create it if it
        #does not exist
        #**************************************************************
        #\\\\\\\\\\\\\\\\\\\\\\\\\**CAUTION**//////////////////////////
        #**************************************************************
        #this will overwrite any file with the same name in the working
        #directory
        #**************************************************************
        htmlFile = open("index.html", "w")
        
        #create string variable formatted in HTML with default content
        htmlContent = "<html>\n<body>\n<h1>" + htmlText +\
        "</h1>\n</body>\n</html>"
        
        #write content to file
        htmlFile.write(htmlContent)
        
        #close file to ensure all data is properly saved
        htmlFile.close()
        
        #open file in the default webbrowser in a new tab
        webbrowser.open_new_tab("index.html")

    
    #this function will create a custom html page
    def customHTML(self):
        
        #create string variable with the custom content
        custText = self.cust_text.get()

        #**************************************************************
        #this will open the file named 'index.html or create it if it
        #does not exist
        #**************************************************************
        #\\\\\\\\\\\\\\\\\\\\\\\\\**CAUTION**//////////////////////////
        #**************************************************************
        #this will overwrite any file with the same name in the working
        #directory
        #**************************************************************
        htmlFile = open("index.html", "w")
        
        #create string variable formatted in HTML with custom content
        htmlContent = "<html>\n<body>\n<h1>" + custText +\
        "</h1>\n</body>\n</html>"
        
        #write content to file
        htmlFile.write(htmlContent)
        
        #close file to ensure all data is properly saved
        htmlFile.close()
        
        #open file in the default webbrowser in a new tab
        webbrowser.open_new_tab("index.html")

#------------------------------------------------------------------------------------------------------
        
#check if running directly
if __name__ == "__main__":
    
    #create a intance of the Tk class
    root = tk.Tk()
    
    #create a instance of ParentWindow class and pass root as the parent  for this instance
    App = ParentWindow(root)
    
    #starts the mainloop which listens for events so the GUI can respond to the user
    root.mainloop()
