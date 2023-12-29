from abc import ABC
from project.animals.animals import Animal
from project.food import Food, Seed, Vegetable, Fruit, Meat


class Mammal(Animal, ABC):
    def __repr__(self):
        return f'{self.__class__.__name__} [{self.name}, {self.weight}, {self.living_region}, {self.food_eaten}]'

    def __init__(self, name: str, weight: float, living_region: str, food_eaten=0):
        super().__init__(name, weight, food_eaten)
        self.living_region = living_region


class Mouse(Mammal):
    def feed(self, food: Food):
        if isinstance(food, Vegetable) or isinstance(food, Fruit):
            self.weight += food.quantity * 0.1
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'Squeak'


class Dog(Mammal):
    def feed(self, food: Food):
        if isinstance(food, Meat):
            self.weight += food.quantity * 0.4
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'Woof!'


class Cat(Mammal):
    def feed(self, food: Food):
        if isinstance(food, Vegetable) or isinstance(food, Meat):
            self.weight += food.quantity * 0.3
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'Meow'


class Tiger(Mammal):
    def feed(self, food: Food):
        if isinstance(food, Meat):
            self.weight += food.quantity * 1
            self.food_eaten += food.quantity
        else:
            return f'{self.__class__.__name__} does not eat {food.__class__.__name__}!'

    def make_sound(self):
        return f'ROAR!!!'
