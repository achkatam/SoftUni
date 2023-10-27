from math import floor

num1 = int(input())
num2 = int(input())

divider = int(input())
multiplier = int(input())

summarize = num1 + num2
divide = summarize / divider
multiply = divide * multiplier
print(floor(multiply))
