from project.cat import Cat


class Kitten(Cat):
    def __init__(self, name: str, age: int, gender='Female'):
        super().__init__(name, age, gender)

    def make_sound(self):
        return f'Meow'
