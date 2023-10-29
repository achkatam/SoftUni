class Zoo:
    __animals = 0  # counter as per requirement

    def __init__(self, name):
        self.name = name
        self.mammals = []
        self.fishes = []
        self.birds = []

    def add_animals(self, species, name):
        if species == "mammal":
            self.mammals.append(name)
        elif species == 'fish':
            self.fishes.append(name)
        elif species == 'birds':
            self.birds.append(name)

        Zoo.__animals += 1

    def get_info(self, species):
        str_builder = ""
        if species == 'mammal':
            str_builder += f"Mammals in {self.name}: {', '.join(self.mammals)}\n"
        elif species == "fish":
            str_builder += f"Fishes in {self.name}: {', '.join(self.fishes)}\n"
        elif species == "bird":
            str_builder += f"Birds in {self.name}: {', '.join(self.birds)}\n"

        str_builder += f"Total animals: {Zoo.__animals}"
        return str_builder


zoo_name = input()
zoo = Zoo(zoo_name)

lines = int(input())

for i in range(lines):
    animal = input().split(" ")
    species = animal[0]
    name = animal[1]

    zoo.add_animals(species, name)

type_animal_info = input()
print(zoo.get_info(type_animal_info))
