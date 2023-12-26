from project.room import Room


class Hotel:
    def __init__(self, name: str) -> None:
        self.name = name
        self.rooms = []
        self.guests = 0

    @classmethod
    def from_stars(cls, stars_count: int):
        name = f'{stars_count} start Hotel'
        return Hotel(name)

    def add_room(self, room: Room):
        self.rooms.append(room)

    def take_room(self, room_number: int, people: int):
        for idx, room in enumerate(self.rooms):
            if room.number == room_number:
                room.take_room(people)
                self.guests += room.guests

    def free_room(self, room_number: int):
        for idx, room in enumerate(self.rooms):
            if room.number == room_number:
                self.guests -= room.guests
                room.free_room()

    def status(self):
        free_rooms = ', '.join(str(i.number) for i in self.rooms if i.is_taken is False)
        taken_rooms = ', '.join(str(i.number) for i in self.rooms if i.is_taken is True)

        return (
            f"Hotel {self.name} has {self.guests} total guests\n"
            f"Free rooms: {free_rooms}\n"
            f"Taken rooms: {taken_rooms}"
        )