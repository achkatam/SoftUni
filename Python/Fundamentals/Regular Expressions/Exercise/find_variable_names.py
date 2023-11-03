import re

text = input()

regex = r"\b(_[A-Za-z0-9]+)\b"

matches = re.findall(regex, text)
valid = []
for i in matches:
    valid.append(i[1:])

print(",".join(valid))
