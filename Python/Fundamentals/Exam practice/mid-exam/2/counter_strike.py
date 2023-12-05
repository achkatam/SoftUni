import sys

init_hp = int(input())

cnt = 0

command = input()

while command != "End of battle":
    needed_hp = int(command)
    if init_hp < needed_hp:
        print(f"Not enough energy! Game ends with {cnt} won battles and {init_hp} energy")
        sys.exit(0)

    init_hp -= needed_hp
    cnt += 1

    if cnt % 3 == 0:
        init_hp += cnt

    command = input()

if init_hp >= 0:
    print(f"Won battles: {cnt}. Energy left: {init_hp}")
