food = int(input()) * 1000

command = input()

temp_food = 0
while command != "Adopted":
    eaten_food = int(command)
    temp_food += eaten_food

    command = input()

food -= temp_food
if food >= 0:
    print(f"Food is enough! Leftovers: {food} grams.")
else:
    print(f"Food is not enough. You need {abs(food)} grams more.")
