class Inventory:
    def __init__(self, __capacity: int):
        self.__capacity = __capacity
        self.__items = []

    def add_item(self, item: str):
        if self.__capacity > len(self.__items):
            self.__items.append(item)
        else:
            return 'not enough room in the inventory'

    def get_capacity(self):
        return self.__capacity

    def __repr__(self):
        output = (f"Items: {', '.join(item for item in self.__items)}\n"
                  f"Capacity left: {self.__capacity - len(self.__items)}")

        return output


inventory = Inventory(2)
inventory.add_item("potion")
inventory.add_item("sword")

print(inventory.add_item('bottle'))
print(inventory.get_capacity())
print(inventory)
