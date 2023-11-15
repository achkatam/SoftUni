def check_index(chest_items: list, index: int):
    return 0 <= index <= len(chest_items) - 1


def loot(chest_items: list, items: list):
    for item in items:
        if item not in chest_items:
            chest_items.insert(0, item)

    return chest_items


def drop(chest_items: list, index: int):
    if check_index(chest_items, index):
        item_to_remove = chest_items[index]
        chest_items.remove(item_to_remove)
        chest_items.append(item_to_remove)

    return chest_items


def steal(chest_items: list, count: int, removed_items: list):
    for i in range(count):
        if len(chest_items) > 0:
            removed_items.append(chest_items[len(chest_items) - 1])
            chest_items.remove(chest_items[len(chest_items) - 1])

    removed_items.reverse()
    print(", ".join(removed_items))

    return chest_items, removed_items


chest_items = input().split("|")

command = input()

while command != "Yohoho!":
    tokens = command.split()
    cmd = tokens[0]
    reversed_items = []
    if cmd == "Loot":
        items = []
        for i in range(1, len(tokens)):
            items.append(tokens[i])
        loot(chest_items, items)
    elif cmd == "Drop":
        index = int(tokens[1])
        drop(chest_items, index)
    elif cmd == "Steal":
        count = int(tokens[1])
        steal(chest_items, count, reversed_items)

    command = input()

result = 0
for i in chest_items:
    result += len(i)
count = len(chest_items)
output = 0
try:
    output = result / count
except:
    pass

if len(chest_items) <= 0:
    print(f"Failed treasure hunt.")
else:
    print(f"Average treasure gain: {output:.2f} pirate credits.")
