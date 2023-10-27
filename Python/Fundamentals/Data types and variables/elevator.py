import math

number_people = int(input())
capacity = int(input())

courses = math.ceil(number_people / capacity)

print(courses)
