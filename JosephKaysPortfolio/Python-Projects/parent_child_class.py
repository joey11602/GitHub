#parent class
class Animal:
    #define the class attribute
    def __init__(instance, body_type, color, weight):
        instance.body_type = body_type
        instance.color = color
        instance.weight = weight

#child class
class Dog(Animal):
    #define the class attribute
    def __init__(instance, body_type, color, weight, breed, sex):
        super().__init__(body_type, color, weight)
        instance.breed = breed
        instance.sex = sex
        

    def bark(instance):
        return "Woof!"

# Child class Fish
class Fish(Animal):
    

    def __init__(instance, body_type, color, weight, species, water_type):
        super().__init__(body_type, color, weight)
        instance.species = species
        instance.water_type = water_type
     

    def swim(instance):
        return "Swimming gracefully."

#trial run
if __name__ == "__main__":
    dog1 = Dog("vertebrate", "brown", 20, "Golden Retriever", "male")
    fish1 = Fish("vertebrate", "red", 0.5, "Red Drum", "saltwater")

    print(f"This dog is a {dog1.body_type}. \nIt is a {dog1.color} {dog1.breed}. \nIt is a {dog1.weight} pound {dog1.sex}. -- {dog1.bark()} \n")
    print(f"This fish is a {fish1.body_type}. \nIt is a {fish1.species} that is {fish1.color} in color and weighs {fish1.weight} pounds. \nIt lives in {fish1.water_type}.-- {fish1.swim()}")
    

