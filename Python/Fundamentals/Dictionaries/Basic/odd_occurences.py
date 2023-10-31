inpt = input().lower().split(" ")

inpt_dict = {}

for i in inpt:
    if i not in inpt_dict.keys():
        inpt_dict[i] = 0
    inpt_dict[i] += 1

output = ""

for key, value in inpt_dict.items():
    if value % 2 != 0:
        output += key + ' '

print(output)
