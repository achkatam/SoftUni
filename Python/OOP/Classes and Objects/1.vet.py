class Vet:
    total_animals = []
    space = 5

    def __init__(self, name: str):
        self.name = name
        self.animals = []

    def register_animal(self, animal_name: str):
        if Vet.space == len(Vet.total_animals):
            return f'Not enough space'
        Vet.total_animals.append(animal_name)
        self.animals.append(animal_name)
        return f'{animal_name} registered in the clinic'

    def unregister_animal(self, animal_name):
        if animal_name in self.animals:
            self.animals.remove(animal_name)
            Vet.total_animals.remove(animal_name)
            return f'{animal_name} unregistered successfully'

        return f'{animal_name} not in the clinic'

    def info(self):
        return f'{self.name} has {len(self.animals)} animals. {Vet.space - len(Vet.total_animals)} space left in the clinic'


if __name__ == '__main__':
    peter = Vet("Peter")
    george = Vet("George")
    print(peter.register_animal("Tom"))
    print(george.register_animal("Cory"))
    print(peter.register_animal("Fishy"))
    print(peter.register_animal("Bobby"))
    print(george.register_animal("Kay"))
    print(george.unregister_animal("Cory"))
    print(peter.register_animal("Silky"))
    print(peter.unregister_animal("Molly"))
    print(peter.unregister_animal("Tom"))
    print(peter.info())
    print(george.info())
