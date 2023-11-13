numbers = [int(x) for x in input().split()]


def swap(numbers: list, index1, index2):
    numbers[index1], numbers[index2] = numbers[index2], numbers[index1]
    return numbers


def multiply(numbers: list, index1: int, index2: int):
    numbers[index1] = numbers[index1] * numbers[index2]
    return numbers


def decrease(numbers: list):
    for i in range(len(numbers)):
        numbers[i] -= 1
    return numbers


command = input()

while command != "end":
    tokens = command.split()
    cmd = tokens[0]

    if cmd == "swap":
        index1 = int(tokens[1])
        index2 = int(tokens[2])
        swap(numbers, index1, index2)
    elif cmd == "multiply":
        index1 = int(tokens[1])
        index2 = int(tokens[2])
        multiply(numbers, index1, index2)
    elif cmd == "decrease":
        decrease(numbers)

    command = input()

print(", ".join(map(str, numbers)))
