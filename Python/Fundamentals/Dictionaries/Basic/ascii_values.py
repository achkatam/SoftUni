inpt = input()

letters = {}
for i in inpt.split(", "):
    if i not in letters.keys():
        letters[i] = ord(i)

print(letters)
