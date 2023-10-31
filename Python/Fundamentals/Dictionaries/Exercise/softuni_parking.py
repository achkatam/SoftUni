users = {}

n = int(input())

for i in range(n):
    command = input().split()
    cmd = command[0]
    username = command[1]

    if cmd == "register":
        lcs_plate = command[2]

        if username not in users:
            users[username] = lcs_plate
            print(f"{username} registered {lcs_plate} successfully")
        else:
            print(f"ERROR: already registered with plate number {lcs_plate}")

    elif cmd == 'unregister':
        if username not in users.keys():
            print(f"ERROR: user {username} not found")
        else:
            del users[username]
            print(f"{username} unregistered successfully")

for username, lcs_plate in users.items():
    print(f'{username} => {lcs_plate}')
