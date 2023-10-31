inpt = input()
chars = {}

for i in inpt:
    if i not in chars:
        if i == " ":
            continue
        chars[i] = 0
    chars[i] += 1

for key, value in chars.items():
    print(f"{key} -> {value}")
