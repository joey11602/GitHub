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
import student_tracking_main
import student_tracking_func

#define load_gui()
def load_gui(self):

    #this defines the default Tkinter widgets and their initial
    #configuration and place them using the grid geometry
    
    #define labels for entry boxes
    self.lbl_fname = tk.Label(self.master, text = 'First Name:')
    self.lbl_fname.grid(row = 0, column = 0, padx = (0, 0), pady = (0, 0))
    self.lbl_lname = tk.Label(self.master, text = 'Last Name:')
    self.lbl_lname.grid(row = 1, column = 0, padx = (0, 0), pady = (0, 0))
    self.lbl_phone = tk.Label(self.master, text = 'Phone Number:')
    self.lbl_phone.grid(row = 2, column = 0, padx = (0, 0), pady = (0, 0))
    self.lbl_email = tk.Label(self.master, text = 'Email Address:')
    self.lbl_email.grid(row = 3, column = 0, padx = (0, 0), pady = (0, 0))
    self.lbl_curCourse = tk.Label(self.master, text = 'Current Course:')
    self.lbl_curCourse.grid(row = 4, column = 0, padx = (0, 0), pady = (0, 0))

    #define entry boxes
    self.txt_fname = tk.Entry(self.master, text = '')
    self.txt_fname.grid(row = 0, column = 1, padx = (0, 0), pady = (0, 0))
    self.txt_lname = tk.Entry(self.master, text = '')
    self.txt_lname.grid(row = 1, column = 1, padx = (0, 0), pady = (0, 0))
    self.txt_phone = tk.Entry(self.master, text = '')
    self.txt_phone.grid(row = 2, column = 1, padx = (0, 0), pady = (0, 0))
    self.txt_email = tk.Entry(self.master, text = '')
    self.txt_email.grid(row = 3, column = 1, padx = (0, 0), pady = (0, 0))
    self.txt_curCourse = tk.Entry(self.master, text = '')
    self.txt_curCourse.grid(row = 4, column = 1, padx = (0, 0), pady = (0, 0))

    #Define the listbox with a scrollbar and grid them
    self.scrollbar1 = Scrollbar(self.master, orient = VERTICAL)
    self.lstList1 = Listbox(self.master, exportselection = 0, yscrollcommand = self.scrollbar1.set)
    self.lstList1.bind('<<ListboxSelect>>', lambda event: student_tracking_func.select(self, event))
    self.scrollbar1.config(command = self.lstList1.yview)
    self.scrollbar1.grid(row = 0, column = 3, rowspan = 5, padx = (0, 0), pady = (0, 0))
    self.lstList1.grid(row = 0, column = 2, rowspan = 5, padx = (0, 0), pady = (10, 0))
    
    #define the buttons
    self.btn_submit = tk.Button(self.master, width = 20, height = 1, text = 'SUBMIT', command = lambda: student_tracking_func.submit(self))
    self.btn_submit.grid(row = 0, column = 5, rowspan = 1, padx = (0, 0), pady = (30, 0))
    self.btn_deleteSelected = tk.Button(self.master, width = 20, height = 1, text = 'DELETE SELECTED', command = lambda: student_tracking_func.deleteSelected(self))
    self.btn_deleteSelected.grid(row = 1, column = 5, rowspan = 1, padx = (0, 0), pady = (0, 0))
    self.btn_clearFields = tk.Button(self.master, width = 20, height = 1, text = 'CLEAR FIELDS', command = lambda: student_tracking_func.clear(self))
    self.btn_clearFields.grid(row = 2, column = 5, rowspan = 1, padx = (0, 0), pady = (0, 0))
    self.btn_refresh = tk.Button(self.master, width = 20, height = 1, text = 'REFRESH', command = lambda: student_tracking_func.refresh(self))
    self.btn_refresh.grid(row = 3, column = 5, rowspan = 1, padx = (0, 0), pady = (0, 0))

    #define labels for column headers
    self.lbl_col_fullName = tk.Label(self.master, text = 'FULL NAME')
    self.lbl_col_fullName.grid(row = 5, column = 0, padx = (0, 0), pady = (50, 0))
    self.lbl_col_phone = tk.Label(self.master, text = '  PHONE NUMBER')
    self.lbl_col_phone.grid(row = 5, column = 1, padx = (70, 0), pady = (50, 0))
    self.lbl_col_email = tk.Label(self.master, text = 'EMAIL ADDRESS  ')
    self.lbl_col_email.grid(row = 5, column = 2, padx = (20, 0), pady = (50, 0))
    self.lbl_col_curCourse = tk.Label(self.master, text = '  CURRENT COURSE')
    self.lbl_col_curCourse.grid(row = 5, column = 3, padx = (70, 0), pady = (50, 0))
    
    #define text widget and scrollbar
    self.textWidget = tk.Text(self.master, wrap = tk.WORD)
    self.textWidget.grid(row = 6,column = 0,columnspan = 5,padx = (10, 0), pady = (0, 0))
    self.scrollbar = tk.Scrollbar(self.master, command = self.textWidget.yview)
    self.scrollbar.grid(row = 6, column = 5, columnspan = 5, padx = (0, 0), pady = (60, 0))
    self.textWidget.config(yscrollcommand = self.scrollbar.set)

    #call create_db() and refresh()
    student_tracking_func.create_db(self)
    student_tracking_func.refresh(self)

#standard dunder "main" code block
if __name__ == "__main__":
    pass
    
