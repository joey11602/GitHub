#create class
class Auto:
    def __init__(self, make, model, year):
        self.make = make
        self.model = model
        self.year = year
    #create a method for the class Auto
    def Horn(self):
        return 'Honk! Honk!'


if __name__ == '__main__':    
    #create an instance of the class Auto
    car01 = Auto('Toyota', 'Camry', 2023)

    print('\nMy new car is a {} {} {}.'.format(car01.year, car01.make, car01.model))
      
