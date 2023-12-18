names = {}
num = int(input())
for i in range(num):
    name = input()

    if name not in names.keys():
        names[name] = 1
    else:
        names[name] += 1

for name in names.keys():
    print(name)
