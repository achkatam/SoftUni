class Treasure:
    def __init__(self, population: int, gold: int):
        self.population = population
        self.gold = gold


def is_positive(gold: int):
    return gold > 0


def plunder(cities: dict, city: str, population: int, gold: int):
    cities[city].population -= population
    cities[city].gold -= gold

    print(f"{city} plundered! {gold} gold stolen, {population} citizens killed.")

    if cities[city].population <= 0 or cities[city].gold <= 0:
        del cities[city]
        print(f"{city} has been wiped off the map!")

    return cities


def prosper(cities: dict, city: str, gold: int):
    if is_positive(gold):
        cities[city].gold += gold
        print(f"{gold} gold added to the city treasury. {city} now has {cities[city].gold} gold.")
        return cities

    print(f"Gold added cannot be a negative number!")
    return cities


def output(cities: dict):
    print(f"Ahoy, Captain! There are {len(cities.keys())} wealthy settlements to go to:")

    for city, values in cities.items():
        print(f"{city} -> Population: {values.population} citizens, Gold: {values.gold} kg")


command = input()

cities = {}

while command != "Sail":
    tokens = command.split("||")
    city = tokens[0]
    population = int(tokens[1])
    gold = int(tokens[2])

    if city not in cities.keys():
        cities[city] = Treasure(population, gold)
    else:
        cities[city].population += population
        cities[city].gold += gold

    command = input()

command = input()

while command != "End":
    tokens = command.split("=>")
    cmd = tokens[0]
    city = tokens[1]

    if cmd == "Plunder":
        population = int(tokens[2])
        gold = int(tokens[3])
        plunder(cities, city, population, gold)
    elif cmd == "Prosper":
        gold = int(tokens[2])
        prosper(cities, city, gold)

    command = input()

output(cities)
