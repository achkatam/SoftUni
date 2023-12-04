import sys

waiting_people = int(input())
wagons = [int(x) for x in input().split()]
wagon_capacity = 4

for i in range(len(wagons)):
    for j in range(wagons[i], wagon_capacity):
        wagons[i] += 1
        waiting_people -= 1

        if waiting_people == 0:
            if sum(wagons) < len(wagons) * wagon_capacity:
                print(f"The lift has empty spots!")
            print(' '.join(map(str, wagons)))
            sys.exit(0)

print(f"There isn't enough space! {waiting_people} people in a queue!")
print(' '.join(map(str, wagons)))
