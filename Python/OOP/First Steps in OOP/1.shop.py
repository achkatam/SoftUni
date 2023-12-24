class Shop:
    def __init__(self, name:str, items: list):
        self.name = name
        self.items = items

    def get_items_count(self):
        return len(self.items)


shop = Shop('My Shop', ['Apple', 'Banana', 'Cucumbers'])
print(shop.get_items_count())
