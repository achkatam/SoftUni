import sys


def reset_hp(initial_hp: int):
    initial_hp = 100
    return initial_hp


def attack(initial_hp: int, damage: int, cmd: str, room_num: int):
    initial_hp -= damage
    if initial_hp <= 0:
        print(f"You died! Killed by {cmd}.")
        print(f"Best room: {room_num + 1}")
        sys.exit(0)
    print(f"You slayed {cmd}.")
    return initial_hp


def potion(initial_hp: int, healed_hp: int, MAX_HP):
    if initial_hp + healed_hp > 100:
        print(f"You healed for {MAX_HP - initial_hp} hp.")
        initial_hp = reset_hp(initial_hp)
    else:
        initial_hp += healed_hp
        print(f"You healed for {healed_hp} hp.")

    print(f"Current health: {initial_hp} hp.")
    return initial_hp


def chest(initial_btc: int, bitcoin_found: int):
    initial_btc += bitcoin_found

    print(f"You found {bitcoin_found} bitcoins.")
    return initial_btc


def output(initial_hp: int, initial_btc: int):
    print(f"You've made it!\nBitcoins: {initial_btc}\nHealth: {initial_hp}")


initial_hp = 100
initial_btc = 0
rooms = input().split("|")
MAX_HP = 100

for i in range(len(rooms)):
    tokens = rooms[i].split()
    cmd = tokens[0]

    if cmd == "potion":
        hp = int(tokens[1])
        initial_hp = potion(initial_hp, hp, MAX_HP)
    elif cmd == "chest":
        btc = int(tokens[1])
        initial_btc = chest(initial_btc, btc)
    else:
        damage = int(tokens[1])
        initial_hp = attack(initial_hp, damage, cmd, i)

output(initial_hp, initial_btc)
