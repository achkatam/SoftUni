string_inpt = input()
first = string_inpt[0]

for i in range(1, len(string_inpt)):
    if string_inpt[i - 1] == string_inpt[i]:
        continue
    first += string_inpt[i]

print(first)
