message = input()

command = input()

while command != "Decode":
    command = input()


def Move(message: str):
    num_letters = int(input())

    for i in range(num_letters):
