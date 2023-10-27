import sys

name = str(input())

while name != 'Welcome!':

    if name == 'Voldemort':
        print("You must not speak of that name!")
        sys.exit(0)

    if name.__len__() < 5:
        print(f"{name} goes to Gryffindor.")
    elif name.__len__() == 5:
        print(f"{name} goes to Slytherin.")
    elif name.__len__() == 6:
        print(f"{name} goes to Ravenclaw.")
    elif name.__len__() > 6:
        print(f"{name} goes to Hufflepuff.")

    name = str(input())

print('Welcome to Hogwarts.')
