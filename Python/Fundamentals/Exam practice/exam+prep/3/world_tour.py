def is_valid(string: str, index: int):
    return 0 <= index < len(string)


def print_string(string):
    print(string)


def add_stop(string: str, index: int, insert_str: str):
    if is_valid(string, index):
        result = string[:index] + insert_str + string[index:]
        return result


def remove_stop(string: str, start_index: int, end_index: int):
    if is_valid(string, start_index) and 0 <= end_index < len(string):
        string = string[:start_index] + string[end_index + 1:]
        return string


def switch_string(string: str, old_string: str, new_string: str):
    if string.find(old_string):
        string = string.replace(old_string, new_string)
        return string


string = input()

command = input()

while command != "Travel":
    tokens = command.split(":")
    cmd = tokens[0]

    if cmd == "Add Stop":
        index = int(tokens[1])
        insert_str = tokens[2]
        string = add_stop(string, index, insert_str)
    elif cmd == "Remove Stop":
        start_index = int(tokens[1])
        end_index = int(tokens[2])
        string = remove_stop(string, start_index, end_index)
    elif cmd == "Switch":
        old_string = tokens[1]
        new_string = tokens[2]
        string = switch_string(string, old_string, new_string)
    print_string(string)
    command = input()

print(f"Ready for world tour! Planned stops: {string}")
