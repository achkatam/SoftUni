def output(message):
    print(f"The decrypted message is: {message}")


def change_all(message, substring, replacement):
    message = message.replace(substring, replacement)
    return message


def insert(message, idx, value):
    message = message[:idx] + value + message[idx:]
    return message


def move(message, num_letters):
    message = message[num_letters:] + message[:num_letters]
    return message


def decode_message(message, cmd_list):
    for command in cmd_list:
        tokens = command.split("|")
        cmd = tokens[0]

        if cmd == "Move":
            num_letters = int(tokens[1])
            message = move(message, num_letters)
        elif cmd == "Insert":
            idx = int(tokens[1])
            value = tokens[2]
            message = insert(message, idx, value)
        elif cmd == "ChangeAll":
            substring = tokens[1]
            replacement = tokens[2]
            message = change_all(message, substring, replacement)
        elif cmd == "Decode":
            output(message)


message = input()

cmd_list = []

while True:
    command = input()
    cmd_list.append(command)

    if command == "Decode":
        break

decode_message(message, cmd_list)
