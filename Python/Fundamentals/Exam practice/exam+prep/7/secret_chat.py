def change_all(string: str, substring: str, new_substring: str):
    string = string.replace(substring, new_substring)
    print(string)
    return string


def reverse(string: str, substring: str):
    if substring not in string:
        print(f"error")
        return

    string = string.replace(substring, "", 1)  # just first occurrence
    string += substring[::-1]  # Reversing
    print(string)
    return string


def insert_space(string: str, idx: int):
    string = string[:idx] + " " + string[idx:]
    print(string)
    return string


string = input()

command = input()

while command != "Reveal":
    tokens = command.split(":|:")
    cmd = tokens[0]

    if cmd == "InsertSpace":
        idx = int(tokens[1])
        string = string[:idx] + " " + string[idx:]
    elif cmd == "Reverse":
        substring = tokens[1]
        string = reverse(string, substring)
    elif cmd == "ChangeAll":
        substring = tokens[1]
        new_substring = tokens[2]
        string = change_all(string, substring, new_substring)

    command = input()

print(f'You have a new text message: {string}')
