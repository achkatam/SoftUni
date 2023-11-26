class Hero:
    def __init__(self, name: str, hp: int, mp: int):
        self.name = name
        self.hp = hp
        self.mp = mp
        self.max_hp = 100
        self.max_mp = 200


def recharge(heroes: dict, name: str, amount: int):

    if amount + heroes[name].mp > heroes[name].max_mp:
        amount = heroes[name].max_mp - heroes[name].mp

    heroes[name].mp += amount
    print(f"{name} recharged for {amount} MP!")


def heal(heroes: dict, name: str, amount: int):
    if amount + heroes[name].hp > heroes[name].max_hp:
        amount = heroes[name].max_hp - heroes[name].hp

    heroes[name].hp += amount
    print(f"{name} healed for {amount} HP!")


def take_damage(heroes: dict, name: str, damage: int, attacker: str):
    heroes[name].hp -= damage

    if heroes[name].hp >= 0:
        print(f"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].hp} HP left!")
    else:
        del heroes[name]
        print(f"{name} has been killed by {attacker}!")

    return heroes


def cast_spell(heroes: dict, name: str, mp_needed: int, spell_name: str):
    if heroes[name].mp < mp_needed:
        print(f"{name} does not have enough MP to cast {spell_name}!")
        return

    heroes[name].mp -= mp_needed
    print(f"{name} has successfully cast {spell_name} and now has {heroes[name].mp} MP!")


num = int(input())

heroes = {}

for i in range(num):
    inpt = input().split()
    name = inpt[0]
    hp = int(inpt[1])
    mp = int(inpt[2])

    heroes[name] = Hero(name, hp, mp)

command = input()

while command != "End":
    tokens = command.split(" - ")
    cmd, name = tokens[0], tokens[1]

    if cmd == "CastSpell":
        mp_needed = int(tokens[2])
        spell_name = tokens[3]
        cast_spell(heroes, name, mp_needed, spell_name)
    elif cmd == "TakeDamage":
        damage = int(tokens[2])
        attacker = tokens[3]
        take_damage(heroes, name, damage, attacker)
    elif cmd == "Recharge":
        amount = int(tokens[2])
        recharge(heroes, name, amount)
    elif cmd == "Heal":
        amount = int(tokens[2])
        heal(heroes, name, amount)

    command = input()

for key, value in heroes.items():
    print(f"{key}")
    print(f" HP: {value.hp}")
    print(f" MP: {value.mp}")
