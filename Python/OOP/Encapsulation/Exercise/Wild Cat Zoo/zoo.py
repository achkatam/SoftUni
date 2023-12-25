class Zoo:
    def __init__(self, name: str, budget: int, animal_capacity: int, workers_capacity: int) -> None:
        self.name = name
        self.__budget = budget
        self.__animal_capacity = animal_capacity
        self.__workers_capacity = workers_capacity

        self.animals = []
        self.workers = []

    def add_animal(self, animal, price):
        if price <= self.__budget and self.__animal_capacity > 0:
            self.animals.append(animal)
            self.__budget -= price
            self.__animal_capacity -= 1
            return f'{animal.name} the {animal.__class__.__name__} added to the zoo'
        elif self.__animal_capacity > 0 and price > self.__budget:
            return f'Not enough budget'
        elif self.__animal_capacity <= 0 and price <= self.__budget:
            return f'Not enough space for animal'

    def hire_worker(self, worker):
        if self.__workers_capacity > 0:
            self.workers.append(worker)
            self.__workers_capacity -= 1
            return f'{worker.name} the {worker.__class__.__name__} hired successfully'

        return f'Not enough space for worker'

    def fire_worker(self, worker_name):
        for worker in self.workers:
            if worker.name == worker_name:
                self.workers.remove(worker)
                return f'{worker_name} fired successfully'

        return f'There is no {worker_name} in the zoo'

    def pay_workers(self):
        total_salaries = 0
        for worker in self.workers:
            total_salaries += worker.salary

        if self.__budget >= total_salaries:
            self.__budget -= total_salaries
            return f'You payed your workers. They are happy. Budget left: {self.__budget}'

        return f'You have no budget to pay your workers. They are unhappy'

    def tend_animals(self):
        total_money_for_care = 0
        for animal in self.animals:
            total_money_for_care += animal.money_for_care

        if self.__budget >= total_money_for_care:
            self.__budget -= total_money_for_care
            return f'You tended all the animals. They are happy. Budget left: {self.__budget}'

        return f'You have no budget to tend the animals. They are unhappy.'

    def profit(self, amount):
        self.__budget += amount

    def animals_status(self):
        new_line = '\n'
        string_builder = ''
        tigers = []
        cheetahs = []
        lions = []

        for i in self.animals:
            if i.__class__.__name__ == "Tiger":
                tigers.append(i)
            elif i.__class__.__name__ == "Cheetah":
                cheetahs.append(i)
            elif i.__class__.__name__ == "Lion":
                lions.append(i)

        if len(self.animals) > 0:
            string_builder += f'You have {len(self.animals)} animals\n'

            if lions:
                string_builder += f'----- {len(lions)} Lions:\n'
                for lion in lions:
                    string_builder += lion.__repr__()
            if tigers:
                string_builder += f'----- {len(tigers)} Tigers:\n'
                for tiger in tigers:
                    string_builder += tiger.__repr__()
            if cheetahs:
                string_builder += f'----- {len(cheetahs)} Cheetahs:\n'
                for cheetah in cheetahs:
                    string_builder += cheetah.__repr__()

        return string_builder

    def workers_status(self):
        new_line = '\n'
        string_builder = ''
        keepers = []
        vets = []
        caretakers = []

        for worker in self.workers:
            if worker.__class__.__name__ == 'Keeper':
                keepers.append(worker)
            if worker.__class__.__name__ == 'Vet':
                vets.append(worker)
            if worker.__class__.__name__ == 'Caretaker':
                caretakers.append(worker)

        if len(self.workers) > 0:
            string_builder += f'You have {len(self.workers)} workers\n'

            if keepers:
                string_builder += f'----- {len(keepers)} Keepers:\n'
                for keeper in keepers:
                    string_builder += keeper.__repr__()
            if caretakers:
                string_builder += f'----- {len(caretakers)} Caretakers:\n'
                for caretaker in caretakers:
                    string_builder += caretaker.__repr__()
            if vets:
                string_builder += f'----- {len(vets)} Vets:\n'
                for vet in vets:
                    string_builder += vet.__repr__()

        return string_builder
