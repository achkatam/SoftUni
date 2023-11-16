def flip(activation_key: str, case: str, index1: int, index2: int):
    the_word = activation_key[index1:index2]
    if case == "Upper":
        activation_key = activation_key[:index1] + the_word.upper() + activation_key[index2:]
    elif case == "Lower":
        activation_key = activation_key[:index1] + the_word.lower() + activation_key[index2:]
    print(activation_key)
    return activation_key


def contains(activation_key: str, substring: str):
    if substring in activation_key:
        print(f"{activation_key} contains {substring}")
    else:
        print(f"Substring not found!")


def slice(activation_key: str, index1: int, index2: int):
    activation_key = activation_key[:index1] + activation_key[index2:]
    print(activation_key)
    return activation_key


activation_key = input()

command = input()

while command != "Generate":
    tokens = command.split(">>>")
    cmd = tokens[0]

    if cmd == "Contains":
        substring = tokens[1]
        contains(activation_key, substring)
    elif cmd == "Flip":
        case = tokens[1]
        index1 = int(tokens[2])
        index2 = int(tokens[3])
        activation_key = flip(activation_key, case, index1, index2)
    elif cmd == "Slice":
        index1 = int(tokens[1])
        index2 = int(tokens[2])
        activation_key = slice(activation_key, index1, index2)

    command = input()

print(f"Your activation key is: {activation_key}")
