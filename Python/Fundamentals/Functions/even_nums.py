def check_even(number):
    if number % 2 == 0:
        return True

    return False


numbers_input = input().split()

numbers = list(map(int, numbers_input))

even_numbers = list(filter(check_even, numbers))

print(even_numbers)
