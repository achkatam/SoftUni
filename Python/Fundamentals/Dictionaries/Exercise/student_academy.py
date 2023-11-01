students = {}

n = int(input())

for i in range(n):
    name = input()
    grade = float(input())

    if name not in students:
        students[name] = []
    students[name].append(grade)

for name, grade in students.items():
    if sum(grade) / (len(grade)) >= 4.50:
        print(f'{name} -> {sum(grade) / (len(grade)):.2f}')
