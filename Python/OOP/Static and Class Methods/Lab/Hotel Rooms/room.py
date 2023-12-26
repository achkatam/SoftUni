class Room:
    def __init__(self, number: int, capacity: int) -> None:
        self.number = number
        self.capacity = capacity
        self.guests = 0
        self.is_taken = False

    def take_room(self, people: int):
        if self.is_taken is False and people <= self.capacity:
            self.guests += people
            self.is_taken = True
            self.capacity -= people
        else:
            return f"Room number {self.number} cannot be taken"

    def free_room(self):
        if self.is_taken is True:
            self.is_taken = False
            self.guests = 0
        else:
            return f"Room number {self.number} is not taken"
