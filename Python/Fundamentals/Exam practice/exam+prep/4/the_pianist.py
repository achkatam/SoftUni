class Symphony:
    def __init__(self, name, author, key):
        self.name = name
        self.author = author
        self.key = key


def change_key(pianist, symphony_name: str, new_key: str):
    if symphony_name not in pianist.keys():
        print(f"Invalid operation! {symphony_name} does not exist in the collection.")
        return

    pianist[symphony_name].key = new_key
    print(f"Changed the key of {symphony_name} to {new_key}!")


def remove(pianist, symphony_name: str):
    if symphony_name not in pianist.keys():
        print(f"Invalid operation! {symphony_name} does not exist in the collection.")
        return

    del pianist[symphony_name]
    print(f"Successfully removed {symphony_name}!")


def add(pianist, symphony_name: str, composer: str, key: str):
    if symphony_name in pianist.keys():
        print(f"{symphony_name} is already in the collection!")
        return

    pianist[symphony_name] = Symphony(symphony_name, composer, key)
    print(f"{symphony_name} by {composer} in {key} added to the collection!")


pianist = {}

num = int(input())

for i in range(num):
    input_data = input().split('|')
    symphony_name, author, key = input_data[0], input_data[1], input_data[2]
    pianist[symphony_name] = Symphony(symphony_name, author, key)

command = input()

while command != "Stop":
    tokens = command.split('|')
    cmd, symphony_name = tokens[0], tokens[1]

    if cmd == "Add":
        composer = tokens[2]
        key = tokens[3]
        add(pianist, symphony_name, composer, key)
    elif cmd == "Remove":
        remove(pianist, symphony_name)
    elif cmd == "ChangeKey":
        new_key = tokens[2]
        change_key(pianist, symphony_name, new_key)
    command = input()

for symphony_name, symphony in pianist.items():
    print(f"{symphony_name} -> Composer: {symphony.author}, Key: {symphony.key}")
