class Symphony:
    def __init__(self, composer, key):
        self.composer = composer
        self.key = key


def solution(cmd_list: list, symphonies: dict):
    for command in cmd_list:
        tokens = command.split("|")
        cmd = tokens[0]

        if cmd == "Add":
            symphony = tokens[1]
            composer = tokens[2]
            key = tokens[3]
            if symphony in symphonies.keys():
                print(f"{symphony} is already in the collection!")
                continue

            symphonies[symphony] = Symphony(composer, key)
            print(f"{symphony} by {composer} in {key} added to the collection!")
        elif cmd == "Remove":
            symphony = tokens[1]
            if symphony not in symphonies.keys():
                print(f"Invalid operation! {symphony} does not exist in the collection.")
                continue

            del (symphonies[symphony])
            print(f"Successfully removed {symphony}!")
        elif cmd == "ChangeKey":
            symphony = tokens[1]
            new_key = tokens[2]
            if symphony not in symphonies.keys():
                print(f"Invalid operation! {symphony} does not exist in the collection.")
                continue

            symphonies[symphony].key = new_key
            print(f"Changed the key of {symphony} to {new_key}!")
        elif cmd == "Stop":
            for key, value in symphonies.items():
                print(f"{key} -> Composer: {value.composer}, Key: {value.key}")


num = int(input())
symphonies = {}

for i in range(num):
    command = input().split('|')
    symphony, composer, key = command[0], command[1], command[2]
    symphonies[symphony] = Symphony(composer, key)

cmd_list = []

while True:
    command = input()
    cmd_list.append(command)

    if command == "Stop":
        break

solution(cmd_list, symphonies)
