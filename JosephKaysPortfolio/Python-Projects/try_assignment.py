

def getData():
    num1 = input("\nInput the first number:")
    num2 = input("\nInput the second number:")
    return num1, num2



def add():
    run = True
    while run:
        num1, num2 = getData()


        try:
            answer = int(num1) + int(num2)
            run = False
        except:
            print("You did not provide a numerical value! Try again.")
    print("{} + {} = {}".format(num1, num2, answer))

add()
            
