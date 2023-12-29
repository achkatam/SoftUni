from abc import ABC

from project.animals.animals import Animal
from project.food import Food, Meat, Fruit, Seed, Vegetable


class Bird(Animal, ABC):

    def __repr__(self):
        return f'{self.__class__.__name__} [{self.name}, {self.wing_size}, {self.weight}, {self.food_eaten}]'

    def __init__(self, name: str, weight: float, wing_size: float, eaten_food=0):
        super().__init__(name, weight, eaten_food)
        self.wing_size = wing_size


class Owl(Bird):
    def feed(self, food: Food):
        if isinstance(food, Meat):
            self.weight += food.quantity * 0.25
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'Hoot Hoot'


class Hen(Bird):
    def feed(self, food: Food):
        if isinstance(food, Meat) or isinstance(food, Vegetable) or isinstance(food, Seed) or isinstance(food, Fruit):
            self.weight += food.quantity * 0.35
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'Cluck'
