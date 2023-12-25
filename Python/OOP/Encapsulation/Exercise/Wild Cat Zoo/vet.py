from project.worker import Worker


class Vet(Worker):
    def __init__(self, name: str, age: int, salary: int) -> None:
        super().__init__(name, age, salary)
