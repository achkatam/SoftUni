factor_num = int(input())
num = int(input())

numbers_list = []

for i in range(1, num + 1):
    numbers_list.append(factor_num * i)

print(numbers_list)
