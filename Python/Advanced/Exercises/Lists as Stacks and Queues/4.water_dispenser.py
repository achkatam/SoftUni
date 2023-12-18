import sys
from collections import deque


def drink(qnty_water: int, ppl):
    commands = input()
    while commands != "End":
        tokens = commands.split()

        if tokens[0] == 'refill':
            ltr = int(tokens[1])
            qnty_water += ltr
        else:
            got_water = ppl.popleft()

            if qnty_water < int(tokens[0]):
                print(f'{got_water} must wait')
                print(f'{qnty_water} liters left')
                sys.exit(0)

            qnty_water -= int(tokens[0])
            print(f'{got_water} got water')

        commands = input()

    print(f'{qnty_water} liters left')


qnty_water = int(input())
ppl = deque()

command = input()
while command != "Start":
    ppl.append(command)

    command = input()

drink(qnty_water, ppl)
