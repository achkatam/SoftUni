string_inpt = input()

strength = 0
output = ''
for i in range(len(string_inpt)):
    symbol = string_inpt[i]

    if symbol != '>' and strength > 0:
        strength -= 1
    elif symbol == '>':
        output += symbol
        strength += int(string_inpt[i + 1])
    else:
        output += symbol

print(output)