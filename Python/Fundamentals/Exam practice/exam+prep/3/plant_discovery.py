def rate(plants: dict, plant: str, rating: float):
    if plant in plants.keys():
        plants[plant]['rating'].append(rating)
    else:
        print(f"error")
    return plants


def update(plants: dict, plant: str, new_rarity: int):
    if plant in plants.keys():
        plants[plant]['rarity'] = new_rarity
    else:
        print(f"error")
    return plants


def reset(plants: dict, plant: str):
    if plant in plants.keys():
        plants[plant]['rating'] = []
    else:
        print(f"error")
    return plants


n = int(input())

plants = {}

for i in range(n):
    inpt = input().split("<->")
    plants[inpt[0]] = {"rarity": int(inpt[1]), "rating": []}

command = input()

while command != "Exhibition":
    tokens = command.split(" - ")
    sub_tokens = tokens[0]

    tokens_sub_tokens = tokens[0].split(": ")
    cmd = tokens_sub_tokens[0]
    plant_name = tokens_sub_tokens[1]

    if cmd == "Rate":
        rating = float(tokens[1])
        plants = rate(plants, plant_name, rating)
    elif cmd == "Update":
        rarity = int(tokens[1])
        plants = update(plants, plant_name, rarity)
    elif cmd == "Reset":
        plants = reset(plants, plant_name)

    command = input()

print(f'Plants for the exhibition:')
for plant, stats in plants.items():
    if stats['rating']:
        print(f"- {plant}; Rarity: {stats['rarity']}; Rating: {sum(stats['rating']) / len(stats['rating']):.2f}")
    else:
        print(f"- {plant}; Rarity: {stats['rarity']}; Rating: 0.00")
