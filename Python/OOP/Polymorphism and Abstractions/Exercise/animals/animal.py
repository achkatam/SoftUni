from abc import ABC, abstractmethod


class Animal(ABC):
    def __init__(self, name: str, age: int, gender: str):
        self.name = name
        self.age = age
        self.gender = gender

    @abstractmethod
    def __repr__(self):
        pass

    @abstractmethod
    def make_sound(self):
        pass
    