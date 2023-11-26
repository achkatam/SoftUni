def subs_cmd(string: str, substring: str, substitute: str):
    if substring not in string:
        print(f'Nothing to replace!')
        return string

    string = string.replace(substring, substitute)
    print(string)
    return string


def cut(string: str, idx: int, length: int):
    new_string = ""
    before_idx = string[:idx]
    after_idx = string[idx + length:]
    new_string = before_idx + after_idx
    print(new_string)
    return new_string


def take_odd(string: str):
    new_string = ""
    for i in range(0, len(string)):
        if i % 2 != 0:
            new_string += string[i]
    print(new_string)
    return new_string


string = input()

command = input()

while command != "Done":
    tokens = command.split(" ")
    cmd = tokens[0]

    if cmd == "TakeOdd":
        string = take_odd(string)
    elif cmd == "Cut":
        idx = int(tokens[1])
        length = int(tokens[2])
        string = cut(string, idx, length)
    elif cmd == "Substitute":
        substring = tokens[1]
        substitute = tokens[2]
        string = subs_cmd(string, substring, substitute)

    command = input()

print(f"Your password is: {string}")
