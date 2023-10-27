import sys

divisor = int(input())

boundary = int(input())
the_number = int

for i in reversed(range(boundary + 1)):
    if i % divisor == 0 and i <= boundary:
        print(i)
        sys.exit(0)
