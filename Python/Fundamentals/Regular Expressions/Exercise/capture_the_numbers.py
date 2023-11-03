import re

data = input()
regex = r"[\d]+"
output = list()

while data:

    matches = re.findall(regex, data)

    for match in matches:

        output.append(match)

    data = input()

print(' '.join(output))