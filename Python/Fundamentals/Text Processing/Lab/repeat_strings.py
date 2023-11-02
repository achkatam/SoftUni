string = input().split()
result = ""

for word in string:
    length = len(word)
    result += word * length

print(result)
