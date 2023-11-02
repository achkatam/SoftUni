first = input()
second = input()

while first in second:
    second = second.replace(first, "")

print(second)
