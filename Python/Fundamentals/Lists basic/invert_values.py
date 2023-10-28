input_string = input()

numbers = input_string.split()
opposites = [-int(number) for number in numbers]

print(opposites)
