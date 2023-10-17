from datetime import datetime, time
import pytz

#define the start and end times
start_time = time(9, 0, 0)  # 9 AM
end_time = time(17, 0, 0)  # 5 PM

#define the time zone for Portland, Oregon
portland_timezone = pytz.timezone('America/Los_Angeles')

#get the current time in Portland, Oregon
portland_time = datetime.now(portland_timezone).time()

# Check if the current time is within the specified range
if start_time <= portland_time <= end_time:
    print("The Portland branch is open.")
else:
    print("The Portland branch is closed.")
    
#format the time to display in 12-hour clock format with AM/PM
fmat_portland_time = portland_time.strftime('%I:%M %p')

#print time in Portland
print(fmat_portland_time)

#define the time zone for New York
new_york_timezone = pytz.timezone('America/New_York')

#get the current time in New York
new_york_time = datetime.now(new_york_timezone).time()

#check if the current time is within the specified range
if start_time <= new_york_time <= end_time:
    print("The New York branch is open.")
else:
    print("The New York branch is closed.")

#format the time to display in 12-hour clock format with AM/PM
fmat_new_york_time = new_york_time.strftime('%I:%M %p')

#print time in New York
print(fmat_new_york_time)

#define the time zone for London
london_timezone = pytz.timezone('Europe/London')

#get the current time in London
london_time = datetime.now(london_timezone).time()

#check if the current time is within the specified range
if start_time <= london_time <= end_time:
    print("The London branch is open.")
else:
    print("The London branch is closed.")

#format the time to display in 12-hour clock format with AM/PM
fmat_london_time = london_time.strftime('%I:%M %p')

#print time in London
print(fmat_london_time)
