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
import os
from tkinter import *
import tkinter as tk
import sqlite3
from tkinter import messagebox

#import the modules created for this program
import student_tracking_gui
import student_tracking_main

#define center_window()
def center_window(self, w, h): #pass in the tkinter frame (master) reference and the w and h
    #get user's screen width and height
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    #calculate x and y coordinates to paint the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo

#catch if the user's clicks on the windows upper-right 'X' to ensure they want to close
def ask_quit(self):
    if messagebox.askokcancel("Exit program", "Okay to exit application?"):
        #call functions to close the program
        self.master.destroy()
        os._exit(0)

#define create_db()
def create_db(self):
    conn = sqlite3.connect('db_StudentTracking.db')
    with conn:
        cur = conn.cursor()
        cur.execute("CREATE TABLE if not exists tbl_Tracking( \
            ID INTEGER PRIMARY KEY AUTOINCREMENT, \
            col_fname TEXT, \
            col_lname TEXT, \
            col_fullname TEXT, \
            col_phone TEXT, \
            col_email TEXT, \
            col_curCourse TEXT \
            );")
        conn.commit()
    conn.close()
    first_run(self)

#define first_run()
#first run check, if empty, add generic info
def first_run(self):
    conn = sqlite3.connect('db_StudentTracking.db')
    with conn:
        cur = conn.cursor()
        cur,count = count_records(cur)
        if count < 1:
            cur.execute("INSERT INTO tbl_Tracking (col_fname,col_lname,col_fullname,col_phone,col_email,col_curCourse) VALUES (?,?,?,?,?,?)", ('John','Doe','John Doe','111-111-1111','jdoe@email.com','English 101'))
            conn.commit()
    conn.close()

#define count_record()
#counter function to return record count
def count_records(cur):
    count = ""
    cur.execute("""SELECT COUNT(*) FROM tbl_Tracking""")
    count = cur.fetchone()[0]
    return cur,count

#define select()
#this function is triggered by clicking a name in the list box
#there is an event listener binded to the list box set up in the student_tracker_gui.py
def select(self,event):
    varList = event.widget
    select = varList.curselection()[0]
    value = varList.get(select) 
    conn = sqlite3.connect('db_StudentTracking.db')
    with conn:
        cursor = conn.cursor()
        cursor.execute("SELECT col_fname,col_lname,col_phone,col_email, col_curCourse FROM tbl_Tracking WHERE col_fullname = (?)", [value])
        varBody = cursor.fetchall()
        #this returns a tuple assigned to the variable varBody from the data base that is indexed by the col_fullname
        #it is sliced up into its seperate parts and inserted into the entry fields
        for data in varBody:
            self.txt_fname.delete(0,END)
            self.txt_fname.insert(0,data[0])
            self.txt_lname.delete(0,END)
            self.txt_lname.insert(0,data[1])
            self.txt_phone.delete(0,END)
            self.txt_phone.insert(0,data[2])
            self.txt_email.delete(0,END)
            self.txt_email.insert(0,data[3])
            self.txt_curCourse.delete(0,END)
            self.txt_curCourse.insert(0,data[4])

#define submit()
#this function submits the data in the entry fields and tests it to be saved to the data base
def submit(self):
    var_fname = self.txt_fname.get()
    var_lname = self.txt_lname.get()
    var_phone = self.txt_phone.get()
    var_email = self.txt_email.get()
    var_curCourse = self.txt_curCourse.get() 
    #normalize the data to keep it consistent in the database
    #this will remove any blank spaces before and after the user's entry
    var_fname = var_fname.strip() 
    var_lname = var_lname.strip()
    #this will ensure that the first character in each word is capitalized
    var_fname = var_fname.title()
    var_lname = var_lname.title()
    #combine our normailzed names into a fullname
    var_fullname = ("{} {}".format(var_fname,var_lname))
    #this will remove any blank spaces before and after the user's entry
    var_phone = var_phone.strip()
    var_email = var_email.strip()
    var_curCourse = var_curCourse.strip()
    #this will ensure that the first character in each word is capitalized
    var_curCourse = var_curCourse.title()
    #check email format
    if not "@" or not "." in var_email: 
        print("Incorrect email format!!!")
    #enforce the user to provide all info in fields     
    if (len(var_fname) > 0) and (len(var_lname) > 0) and (len(var_phone) > 0) and(len(var_email) > 0) and (len(var_curCourse) >0): 
        conn = sqlite3.connect('db_StudentTracking.db')
        with conn:
            cursor = conn.cursor()
            #check the database for existance of the fullname, if so we will alert user and disregard request
            cursor.execute("SELECT COUNT(col_fullname) FROM tbl_Tracking WHERE col_fullname = '{}'".format(var_fullname))#,(var_fullname))
            count = cursor.fetchone()[0]
            chkName = count
            if chkName == 0: #if this is 0 then there is no existance of the fullname and we can add new data
                cursor.execute("INSERT INTO tbl_Tracking (col_fname,col_lname,col_fullname,col_phone,col_email,col_curCourse) VALUES (?,?,?,?,?,?)",(var_fname,var_lname,var_fullname,var_phone,var_email,var_curCourse))
                
            else:
                messagebox.showerror("Name Error","'{}' already exists in the database! Please choose a different name.".format(var_fullname))
                #call the function to clear all of the textboxes 
                clear(self) 
        conn.commit()
        conn.close()
        #call the function to refresh the gui
        refresh(self)
        #call the function to clear all of the textboxes
        clear(self) 
    else:
        messagebox.showerror("Missing Text Error","Please ensure that there is data in all four fields.")

#define deleteSelected()
#this will delete the data associated with the full name that has been selected from the gui and the data base
def deleteSelected(self):
    var_select = self.lstList1.get(self.lstList1.curselection()) #listbox's selected value
    conn = sqlite3.connect('db_StudentTracking.db')
    with conn:
        cur = conn.cursor()
        #check count to ensure that this is not the last record in
        #the database...cannot delete last record or we will get an error
        cur.execute("SELECT COUNT(*) FROM tbl_Tracking")
        count = cur.fetchone()[0]
        if count > 1:
            confirm = messagebox.askokcancel("Delete Confirmation", "All information associated with, ({}) \nwill be permenantly deleted from the database. \n\nProceed with the deletion request?".format(var_select))
            if confirm:
                conn = sqlite3.connect('db_StudentTracking.db')
                with conn:
                    cursor = conn.cursor()
                    cursor.execute("""DELETE FROM tbl_Tracking WHERE col_fullname = '{}'""".format(var_select))
                #call the function to refresh the gui
                refresh(self)
                #call the function to clear all of the textboxes
                clear(self) 
                conn.commit()
        else:
            confirm = messagebox.showerror("Last Record Error", "({}) is the last record in the database and cannot be deleted at this time. \n\nPlease add another record first before you can delete ({}).".format(var_select,var_select))
    conn.close()
    
#define clear()
def clear(self):
    #clear the text in these textboxes
    self.txt_fname.delete(0,END)
    self.txt_lname.delete(0,END)
    self.txt_phone.delete(0,END)
    self.txt_email.delete(0,END)
    self.txt_curCourse.delete(0,END)

#define refresh()
#this function refreshes the gui with the changes
def refresh(self):
    #clear the listbox
    self.lstList1.delete(0, tk.END)

    #clear the textWidget
    self.textWidget.delete(1.0, tk.END)
    
    conn = sqlite3.connect('db_StudentTracking.db')
    with conn:
        cursor = conn.cursor()
        cursor.execute("SELECT col_fullname, col_phone, col_email, col_CurCourse FROM tbl_Tracking")
        data = cursor.fetchall()
        #update listbox with the new fullname
        self.lstList1.insert(END, data[0]) 
        #define column widths in the text widget
        column_widths = [16,13,20,16]
        #format and insert data
        for row in data:
            for i, value in enumerate(row):
                self.textWidget.insert(tk.END, "  " + value.ljust(column_widths[i]) + "  ")
            #go to next line
            self.textWidget.insert(tk.END, "\n")
        cursor.execute("""SELECT COUNT(*) FROM tbl_Tracking""")
        count = cursor.fetchone()[0]
        i = 0
        while i < count:
                cursor.execute("""SELECT col_fullname FROM tbl_Tracking""")
                varList = cursor.fetchall()[i]
                for item in varList:
                    self.lstList1.insert(0,str(item))
                    i = i + 1
    conn.close()

#standard dunder "main" code block
if __name__ == "__main__":
    pass


