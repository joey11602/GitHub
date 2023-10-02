class Person:
    def __init__(self, name, age):
        self.__name = name  #private attribute with double underscores
        self._age = age     #protected attribute with a single underscore

#this is an object of the Person class
person1 = Person("Alice", 30)

#access the protected attribute
print(person1._age)              

#access the private attribute
print(person1._Person__name)     
#this first caused me a bit of confusion but after some research it is name mangling
#to access the private attribute I must use a single underscore and the class name\
#followed by the double underscore and private placeholder, in this case 'name'
