import re

text = input()
expression = r"(^| )(?P<valid>([a-z0-9]+[-_.]*)+@([a-z]+[\-]?)+\.([a-z]+[\-]?)([\.]?[a-z]+[\-]?)?)\b"


matches = re.finditer(expression, text)

for match in matches:
    print(match.group("valid"))