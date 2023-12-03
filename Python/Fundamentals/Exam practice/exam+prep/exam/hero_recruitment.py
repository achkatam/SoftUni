class Hero:
    def __init__(self, name):
        self.name = name
        self.spell_names = set()


heroes = {}

command = input()
while command != "End":
    tokens = command.split()
    cmd = tokens[0]

    if cmd == "Enroll":
        hero_name = tokens[1]
        if hero_name in heroes:
            print(f"{hero_name} is already enrolled.")
        else:
            heroes[hero_name] = Hero(hero_name)
    elif cmd == "Learn":
        hero_name = tokens[1]
        spell_name = tokens[2]
        if hero_name not in heroes:
            print(f"{hero_name} doesn't exist.")
        else:
            hero = heroes[hero_name]
            if spell_name in hero.spell_names:
                print(f"{hero_name} has already learnt {spell_name}.")
            else:
                hero.spell_names.add(spell_name)
    elif cmd == "Unlearn":
        hero_name = tokens[1]
        spell_name = tokens[2]
        if hero_name not in heroes:
            print(f"{hero_name} doesn't exist.")
        else:
            hero = heroes[hero_name]
            if spell_name not in hero.spell_names:
                print(f"{hero_name} doesn't know {spell_name}.")
            else:
                hero.spell_names.remove(spell_name)

    command = input()

print("Heroes:")
for key, value in heroes.items():
    print(f"== {value.name}: {', '.join(value.spell_names)}")
