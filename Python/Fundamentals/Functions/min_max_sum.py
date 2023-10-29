def min_number(numbers):
    print(f'The minimum number is {min(numbers)}')


def max_number(numbers):
    print(f'The maximum number is {max(numbers)}')


def sum_numbers(numbers):
    print(f'The sum number is: {sum(numbers)}')


numbers = list(map(int, input().split()))

min_number(numbers)
max_number(numbers)
sum_numbers(numbers)
