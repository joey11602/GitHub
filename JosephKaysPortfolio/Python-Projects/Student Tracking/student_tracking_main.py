#!/usr/bin/python

# -*- coding: utf-8 -*-

#
# Python Ver:   3.11.5
#
# Author:       Joseph D. Kay
#
# Purpose:      This is a class assignment for the Python Course
#

#import python modules
from tkinter import *
import tkinter as tk
from tkinter import messagebox

#import the modules created for this program
import student_tracking_gui
import student_tracking_func

#frame is the Tkinter frame class that our own class will inherit from
class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        #define our master frame configuration
        self.master = master
        self.master.minsize(1000,800) #(Width,Height)
        self.master.maxsize(1000,800)
        # This CenterWindow method will center our app on the user's screen
        student_tracking_func.center_window(self,1000,800)
        self.master.title("Student Tracking")
        self.master.configure(bg="#F0F0F0")
        #this protocol method is a tkinter built-in method to catch if 
        #the user clicks the upper corner, "X" on Windows OS.
        self.master.protocol("WM_DELETE_WINDOW", lambda: student_tracking_func.ask_quit(self))
        #load the gui widgets 
        student_tracking_gui.load_gui(self)

#standard dunder "main" code block
if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
