def check_content(groceries: list, item: str):
    return item in groceries


def urgent(groceries: list, item: str):
    if not check_content(groceries, item):
        groceries.insert(0, item)
        return groceries


def unnecessary(groceries: list, item: str):
    if check_content(groceries, item):
        groceries.remove(item)
        return groceries


def correct(groceries: list, old_item: str, new_item: str):
    if check_content(groceries, old_item):
        idx = groceries.index(old_item)
        groceries[idx] = new_item
        return groceries


def rearrange(groceries: list, item: str):
    if check_content(groceries, item):
        groceries.remove(item)
        groceries.append(item)


groceries = [x for x in input().split("!")]

command = input()
while command != "Go Shopping!":
    tokens = command.split(" ")
    cmd = tokens[0]

    if cmd == "Urgent":
        item = tokens[1]
        urgent(groceries, item)
    elif cmd == "Unnecessary":
        item = tokens[1]
        unnecessary(groceries, item)
    elif cmd == "Correct":
        old_item = tokens[1]
        new_item = tokens[2]
        correct(groceries, old_item, new_item)
    elif cmd == "Rearrange":
        item = tokens[1]
        rearrange(groceries, item)

    command = input()

print(", ".join(groceries))
