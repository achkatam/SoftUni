numbers_input = input().split()

numbers = list(map(int, numbers_input))
numbers.sort()

print(numbers)
