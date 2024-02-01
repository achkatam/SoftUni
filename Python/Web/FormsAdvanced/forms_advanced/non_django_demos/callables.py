class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def __call__(self, *args, **kwargs):
        return f"{self.name} is {self.age} years old."


p = Person("John Doe", 30)

print(p())
