import re

text = input()

pattern = r'#([\w+\s]+)#(\d{2}\/\d{2}\/\d{2})#(\d+)#|\|([\w+\s]+)\|(\d{2}\/\d{2}\/\d{2})\|(\d+)\|'
filtered = re.findall(pattern, text)
clear_list = []

for row in filtered:
    cleared = []
    for value in row:
        if value:
            cleared.append(value)
    clear_list.append(cleared)

total_cals = sum(int(calories[2]) for calories in clear_list)
days = total_cals // 2000
print(f"You have food to last you for: {days} days!")

if days > 0:
    for product in clear_list:
        print(f"Item: {product[0]}, Best before: {product[1]}, Nutrition: {product[2]}")
