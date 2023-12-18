num = int(input())

elements = set()
for _ in range(num):
    inpt = input()
    for i in inpt.split():
        elements.add(i)

print('\n'.join(elements))
