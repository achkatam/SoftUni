from abc import ABC, abstractmethod
from project.food import Food


class Animal(ABC):
    def __init__(self, name: str, weight: float, food_eaten=0):
        self.name = name
        self.weight = weight
        self.food_eaten = food_eaten

    @abstractmethod
    def make_sound(self):
        pass

    @abstractmethod
    def feed(self, food: Food):
        pass

    @abstractmethod
    def __repr__(self):
        pass
