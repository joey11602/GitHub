#parent class
class vehicle:
    
    #initializing common attributes for all vehicles
    def __init__(self, make, model, year):

        #instance variables for passing arguments
        self.make = make  
        self.model = model  
        self.year = year  
        self.speed = 0
        
    #common method for all vehicles
    def accelerate(self, speed_value):
        self.speed += speed_value
        
    #common method for all vehicles
    def brake(self, speed_value):
        self.speed -= speed_value

#child class car
class car(vehicle):
    
   #initializing common attributes for all vehicles and car-specific attributes 
    def __init__(self, make, model, year, num_doors, fuel_type):
        
        #call parent class constructor
        super().__init__(make, model, year)

        #instance variables for passing arguments
        self.num_doors = num_doors   
        self.fuel_type = fuel_type
        
    #method for car only
    def honk(self):
        return "Honk! Honk!"

#child class bicycle
class bicycle(vehicle):

    #initializing common attributes for all vehicles and bicycle-specific attributes
    def __init__(self, make, model, year, frame_material, num_gears):

        #call parent class constructor
        super().__init__(make, model, year)

        #instance variables for passing arguments
        self.frame_material = frame_material  
        self.num_gears = num_gears  

    #method for bicycle only
    def pedal(self):
        return "Pedaling away!"

#create instances of the child classes
car1 = car("Toyota", "Camry", 2022, 4, "gas")
bicycle1 = bicycle("Schwinn", "FX2", 2021, "aluminum", 16)

#show class attributes and methods
print(f"\n{car1.make} {car1.model} ({car1.year}) - {car1.num_doors} doors, {car1.fuel_type} fuel \n")
print(f"{bicycle1.make} {bicycle1.model} ({bicycle1.year}) - {bicycle1.frame_material} frame, {bicycle1.num_gears} gears \n")

#accelerate the car
car1.accelerate(30)
print(f"car speed: {car1.speed} mph \n")

#bicycle pedaling
print(bicycle1.pedal())
