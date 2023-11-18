import sys


def func(num: int):
    return num % 2 == 0 and num % 3 == 0


n = int(input())
m = int(input())
s = int(input())

addresses = []

for i in range(n, m + 1).__reversed__():

    if func(i):
        if i == s:
            break
        addresses.append(i)

print(" ".join(map(str, addresses)))
