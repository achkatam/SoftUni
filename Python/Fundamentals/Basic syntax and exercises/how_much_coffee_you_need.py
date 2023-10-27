string = str(input())

coffees_needed = 0


def check_string_for_events(string_to_check):
    events = ["dog", 'cat', 'movie', 'coding']
    if string.lower() in events:
        return True


while string != "END":

    if check_string_for_events(string):
        if string.isupper():
            coffees_needed += 2
        else:
            coffees_needed += 1

    string = str(input())


if coffees_needed <= 5:
    print(coffees_needed)
else:
    print(f"You need extra sleep")
