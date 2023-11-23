def print_output(string: str):
    print(f"The decrypted message is: {string}")


def move(string: str, num_letters: int):
    letters_to_add = string[0:num_letters]
    string = string[num_letters:(len(string))] + letters_to_add

    return string


def insert(string: str, idx: int, value: str):
    string = string[0:idx] + value + string[idx: len(string)]

    return string


def change_all(string: str, substring: str, new_string: str):
    string = string.replace(substring, new_string)

    return string


string = input()

command = input()

while command != "Decode":
    tokens = command.split("|")
    cmd = tokens[0]

    if cmd == "Move":
        num_letters = int(tokens[1])
        string = move(string, num_letters)
    elif cmd == "Insert":
        idx = int(tokens[1])
        value = tokens[2]
        string = insert(string, idx, value)
    elif cmd == "ChangeAll":
        substring = tokens[1]
        new_substring = tokens[2]
        string = change_all(string, substring, new_substring)

    command = input()

print_output(string)
