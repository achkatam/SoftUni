import re

names = input()
regex = r"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b"

matches = re.finditer(regex, names)

for i in matches:
    print(i[0], end=' ')