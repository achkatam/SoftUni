def sum_numbers(num1, num2):
    return num1 + num2


def subtract(num1, num2):
    print(num1 - num2)


def add_and_subtract(num1, num2, num3):
    sum = sum_numbers(num1, num2)

    subtract(sum, num3)


num1 = int(input())
num2 = int(input())
num3 = int(input())

add_and_subtract(num1, num2, num3)
