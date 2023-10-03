#import the abc module with the ABC(@abstractmethod)
from abc import ABC, abstractmethod

#create the parent class that is a subclass of (ABC)
class BankAccount(ABC):
    #use the constructor method to initialize the attributes for this class
    def __init__(self, account_number, balance):
        self.account_number = account_number
        self.balance = balance

    #this is my abstract method in my parent class
    #this is called the abstractmethod decorator
    #it signals to both programmers and the python interpreter that this method is meant to be overridden in it's child class
    @abstractmethod
    def deposit(self, amount):
        pass#this is used as a placeholder, there is no implementation done here 
            #the child class has to provide implementation for this method 

    #this is my regular method in my parent class
    def get_balance(self):
        return self.balance

#create the child class
class SavingsAccount(BankAccount):
    #use the constructor method to initialize the attributes for this class
    def __init__(self, account_number, balance):
        self.account_number = account_number
        self.balance = balance

    #redefine the implementation of the parents abstract method.    
    def deposit(self, amount):
        print('Thank you for your deposit of ${}.'.format(amount))

#create the object SavingsAccount1 and pass in the parameters
SavingsAccount1 = SavingsAccount('12345', 1000)

#call the inherited and redefined abstract method and pass in its parameter
SavingsAccount1.deposit(1000)
#print out a string that utilzes the regular method that is inherited from the parent class
print('Your Savings account {} has a balance of ${}.'.format(SavingsAccount1.account_number, SavingsAccount1.get_balance()))
    
