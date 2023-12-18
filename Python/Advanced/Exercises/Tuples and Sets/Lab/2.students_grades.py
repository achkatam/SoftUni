def average(grades):
    return (sum(grades) / len(grades))


num = int(input())
pairs = {}

for _ in range(num):
    tokens = input().split()
    name = tokens[0]
    grade = float(tokens[1])

    if name not in pairs.keys():
        pairs[name] = [grade]
    else:
        pairs[name] += [grade]

for name, grades in pairs.items():
    print(f'{name} -> ', end="")
    for grade in grades:
        print(f'{grade:.2f}', end=" ")
    print(f'(avg: {average(grades):.2f})')
