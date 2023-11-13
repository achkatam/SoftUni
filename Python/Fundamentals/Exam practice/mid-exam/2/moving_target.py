import sys


def if_exist(index: int, targets: list):
    return 0 <= index and index <= len(targets) - 1


def shoot(index: int, power: int, targets: list):
    if if_exist(index, targets):
        targets[index] -= power
        if targets[index] <= 0:
            targets.remove(targets[index])
    return targets


def add(index: int, value: int, targets: list):
    if if_exist(index, targets):
        targets.insert(index, value)
        return targets
    else:
        print(f"Invalid placement!")


def strike(index: int, radius: int, targets: list):
    if not if_exist(index, targets) or index - radius < 0 or index + radius > len(targets) - 1:
        print(f"Strike missed!")
        return

    start_index = index - radius
    end_index = index + radius

    del targets[start_index: end_index + 1]
    # targets = [targets[i] for i in range(len(targets)) if i < start_index or i > end_index]
    return targets


targets = [int(x) for x in input().split()]

command = input()

while command != "End":
    tokens = command.split()
    cmd, index = tokens[0], int(tokens[1])

    if cmd == "Shoot":
        power = int(tokens[2])
        shoot(index, power, targets)
    elif cmd == "Add":
        value = int(tokens[2])
        add(index, value, targets)
    elif cmd == "Strike":
        radius = int(tokens[2])
        strike(index, radius, targets)

    command = input()

print('|'.join(map(str, targets)))
