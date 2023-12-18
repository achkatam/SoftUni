vip = []
regular = []

num = int(input())

for _ in range(num):
    code = input()
    if code[0].isdigit():
        if code not in vip:
            vip.append(code)
    else:
        if code not in regular:
            regular.append(code)

command = input()

while command != "END":
    if command in vip:
        vip.remove(command)
    elif command in regular:
        regular.remove(command)

    command = input()

print(f'{len(vip) + len(regular)}')
vip.sort()
regular.sort()

print("\n".join(vip))
print("\n".join(regular))
