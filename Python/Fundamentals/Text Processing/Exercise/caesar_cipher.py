inpt = input()

encrypted = ""
for ch in inpt:
    encrypted += chr(ord(ch) + 3)

print(encrypted)
