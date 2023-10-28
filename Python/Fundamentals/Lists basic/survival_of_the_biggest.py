list_input = input().split()
nums_to_remove = int(input())

# Convert the input strings to int OR u can use map()
list_nums = [int(num) for num in list_input]

for i in range(nums_to_remove):
    min_number = min(list_nums)
    list_nums.remove(min_number)

print(f', '.join(map(str, list_nums)))
