def collect(collection_items: list, item: str):
    if item not in collection_items:
        collection_items.append(item)
        return collection_items


def drop(collection_items: list, item: str):
    if item in collection_items:
        collection_items.remove(item)
        return collection_items


def combine_items(collection_items: list, old_item: str, new_item: str):
    if old_item in collection_items:
        idx = collection_items.index(old_item)
        collection_items.insert(idx + 1, new_item)
        return collection_items


def renew(collection_items: list, item: str):
    if item in collection_items:
        collection_items.remove(item)
        collection_items.append(item)
        return collection_items


collection_items = list(input().split(", "))

command = input()

while command != "Craft!":
    tokens = command.split(" - ")
    cmd = tokens[0]

    if cmd == "Collect":
        item = tokens[1]
        collect(collection_items, item)
    elif cmd == "Drop":
        item = tokens[1]
        drop(collection_items, item)
    elif cmd == "Combine Items":
        items = tokens[1].split(":")
        old_item = items[0]
        new_item = items[1]
        combine_items(collection_items, old_item, new_item)
    elif cmd == "Renew":
        item = tokens[1]
        renew(collection_items, item)

    command = input()

print(", ".join(collection_items))
