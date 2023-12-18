num = int(input())
names = set()

for _ in range(num):
    name = input()
    names.add(name)

print("\n".join(names))
