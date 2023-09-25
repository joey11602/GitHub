#create parent class
class Animal:
    def __init__(self, name, species):
        self.name = name
        self.species = species

    #create a parent class method
    def speak(self):
        pass  #this will be polymorphed by the child class


#create child class
class Dog(Animal):
    def __init__(self, name, breed):
        Animal.__init__(self, name, species="Dog")
        self.breed = breed

    #polymorph the speak(self) method
    def speak(self):
        print(f'{self.name} says Woof!\n')


#create another child class
class Cat(Animal):
    def __init__(self, name, color):
        Animal.__init__(self, name, species="Cat")
        self.color = color

    #polymorph the speak(self) method
    def speak(self):
        print(f'{self.name} says Meow!\n')

#check if this script is being run as the main program
if __name__ == '__main__':
    #create an instance of the child class 'Dog'
    dog1 = Dog('Fido', 'German Shepherd')
    #create an instance of the child class 'Cat'
    cat1 = Cat('Garfield', 'orange')
    #print out child class information and call their methods
    print(f'Name: {dog1.name} \nSpecies: {dog1.species} \nBreed: {dog1.breed}')
    dog1.speak()
    print(f'Name: {cat1.name} \nSpecies: {cat1.species} \nColor: {cat1.color}')
    cat1.speak()
