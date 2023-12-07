def is_valid(weapon_name, idx):
    return 0 <= idx < len(weapon_name)


weapon_name = input().split("|")
command = input()

while command != "Done":
    tokens = command.split(" ")
    cmd = tokens[0]

    if cmd == "Add":
        particle = tokens[1]
        idx = int(tokens[2])
        if is_valid(weapon_name, idx):
            weapon_name.insert(idx, particle)
    elif cmd == "Remove":
        idx = int(tokens[1])
        if is_valid(weapon_name, idx):
            char_to_remove = weapon_name[idx]
            weapon_name.remove(char_to_remove)
    elif cmd == "Check":
        odd_even = tokens[1]
        string = ""
        if odd_even == "Even":
            for i in range(len(weapon_name)):
                if i % 2 == 0:
                    string += weapon_name[i] + " "
        else:
            for i in range(len(weapon_name)):
                if i % 2 != 0:
                    string += weapon_name[i] + " "
        print(string)

    command = input()

print(f"You crafted {''.join(weapon_name)}!")
