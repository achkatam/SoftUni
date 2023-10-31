legendary_item = ""

items = {
    'shards': 0,
    'fragments': 0,
    'motes': 0
}


def add_item(item: str, qnty: int):
    global items
    if item not in items:
        items[item] = 0
    items[item] += qnty


def check_legendary():
    global legendary_item
    goal = 250

    if items['shards'] >= goal:
        legendary_item = 'Shadowmourne'
        items['shards'] -= goal
    elif items['fragments'] >= goal:
        legendary_item = 'Valanyr'
        items['fragments'] -= goal
    elif items['motes'] >= goal:
        legendary_item = 'Dragonwrath'
        items['motes'] -= goal


while True:
    if legendary_item:
        break

    other_items = input().split()

    for i in range(0, len(other_items), 2):
        item = other_items[i + 1].lower()
        quantity = int(other_items[i])

        add_item(item, quantity)
        check_legendary()

        if legendary_item:
            break

    print(f"{legendary_item} obtained!")
    for item, quantity in items.items():
        print(f"{item}: {quantity}")