from project.animal import Animal


class Cheetah(Animal):
    def __init__(self, name: str, gender: str, age: int) -> None:
        self.name = name
        self.gender = gender
        self.age = age
        self.money_for_care = 60
