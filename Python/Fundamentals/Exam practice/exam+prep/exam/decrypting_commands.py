text = input()

command = input()

while command != "Finish":
    tokens = command.split()
    cmd = tokens[0]

    if cmd == "Replace":
        curr_char = tokens[1]
        new_char = tokens[2]
        text = text.replace(curr_char, new_char)
        print(text)
    elif cmd == "Cut":
        start_index = int(tokens[1])
        end_index = int(tokens[2])
        if 0 <= start_index < len(text) and 0 <= end_index < len(text):
            text = text[:start_index] + text[end_index + 1:]
            print(text)
        else:
            print(f"Invalid indices!")
    elif cmd == "Make":
        casing = tokens[1]
        if casing == "Upper":
            text = text.upper()
        else:
            text = text.lower()
        print(text)
    elif cmd == "Check":
        substring = tokens[1]
        if substring in text:
            print(f"Message contains {substring}")
        else:
            print(f"Message doesn't contain {substring}")
    elif cmd == "Sum":
        start_index = int(tokens[1])
        end_index = int(tokens[2])
        if 0 <= start_index < len(text) and 0 <= end_index < len(text):
            substring = text[start_index:end_index + 1]
            sum = 0
            for i in substring:
                sum += ord(i)
            print(sum)
        else:
            print(f"Invalid indices!")

    command = input()
