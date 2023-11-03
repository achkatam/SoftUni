import re

text = input()

needed_word = input()

regex = re.findall(rf"\b{needed_word}\b", text, re.IGNORECASE)

print(len(regex))
