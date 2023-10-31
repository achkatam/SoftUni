command = input()

mine_dict = {}
while command != "stop":
    qnty = int(input())
    if command not in mine_dict:
        mine_dict[command] = 0
    mine_dict[command] += qnty

    command = input()

for key, value in mine_dict.items():
    print(f"{key} -> {value}")
