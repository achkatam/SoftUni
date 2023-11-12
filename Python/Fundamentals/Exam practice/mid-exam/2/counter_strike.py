import sys

initial_energy = int(input())

command = input()
counter = 0
while command != "End of battle":
    distance = int(command)
    if distance > initial_energy:
        print(f"Not enough energy! Game ends with {counter} won battles and {initial_energy} energy")
        sys.exit(0)

    initial_energy -= distance
    counter += 1

    if counter % 3 == 0:
        initial_energy += counter

    command = input()

if initial_energy >= 0:
    print(f"Won battles: {counter}. Energy left: {initial_energy}")
