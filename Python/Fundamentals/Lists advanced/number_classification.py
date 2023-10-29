inpt = [int(num) for num in input().split(', ')]

pos_nums = [num for num in inpt if num >= 0]
negative_nums = [num for num in inpt if num < 0]
even_nums = [num for num in inpt if num % 2 == 0]
odd_nums = [num for num in inpt if num % 2 != 0]

print(f'Positive:', ', '.join(map(str, pos_nums)))
print(f'Negative:', ', '.join(map(str, negative_nums)))
print(f'Even:', ', '.join(map(str, even_nums)))
print(f'Odd:', ', '.join(map(str, odd_nums)))
