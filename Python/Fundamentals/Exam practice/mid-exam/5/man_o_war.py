import sys


def valid_index(lst: list, index: int):
    return 0 <= index < len(lst)


def fire(warship_sections: list, index: int, damage: int):
    if valid_index(warship_sections, index):
        warship_sections[index] -= damage
        if warship_sections[index] <= 0:
            print(f"You won! The enemy ship has sunken.")
            sys.exit(0)
    return warship_sections


def defend(pirate_list: list, start_index: int, end_index: int, damage: int):
    if valid_index(pirate_list, start_index) and valid_index(pirate_list, end_index):
        for i in range(start_index, end_index + 1):
            pirate_list[i] -= damage
            if pirate_list[i] <= 0:
                print(f"You lost! The pirate ship has sunken.")
                sys.exit(0)

    return pirate_list


def repair(pirate_sections: list, index: int, heal: int, max_hp: int):
    if valid_index(warship_sections, index):
        pirate_sections[index] += heal

        if pirate_sections[index] > max_hp:
            pirate_sections[index] = max_hp
    return pirate_sections


def status(pirate: list):
    cnt = 0
    for i in pirate:
        limit = max_hp * 0.2
        if i < limit:
            cnt += 1
    print(f"{cnt} sections need repair.")
    return


pirate_ship_sections = [int(x) for x in input().split(">")]
warship_sections = [int(x) for x in input().split(">")]

max_hp = int(input())

command = input()

while command != "Retire":
    tokens = command.split()
    cmd = tokens[0]

    if cmd == "Fire":
        index = int(tokens[1])
        damage = int(tokens[2])
        fire(warship_sections, index, damage)
    elif cmd == "Defend":
        start_idx = int(tokens[1])
        end_idx = int(tokens[2])
        damage = int(tokens[3])
        defend(pirate_ship_sections, start_idx, end_idx, damage)
    elif cmd == "Repair":
        index = int(tokens[1])
        heal = int(tokens[2])
        repair(pirate_ship_sections, index, heal, max_hp)
    elif cmd == "Status":
        status(pirate_ship_sections)

    command = input()

pirate_output = sum(pirate_ship_sections)
warship_output = sum(warship_sections)

print(f"Pirate ship status: {pirate_output}")
print(f"Warship status: {warship_output}")
