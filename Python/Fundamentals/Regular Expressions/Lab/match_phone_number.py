import re

regex = r"\+359([ |-])2\1([0-9]{3})\1([0-9]{4})\b"

phone_numbers = input()

matches = re.finditer(regex, phone_numbers)

valid_number = list()

for i in matches:
    valid_number.append(i[0])

print(", ".join(valid_number))
