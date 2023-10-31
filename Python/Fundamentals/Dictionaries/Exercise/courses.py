courses = {}

command = input()

while command != "end":
    tokens = command.split(" : ")
    course = tokens[0]
    student = tokens[1]

    if course not in courses.keys():
        courses[course] = []
    courses[course].append(student)

    command = input()

for course, student in courses.items():
    print(f"{course}: {len(student)}")
    for name in student:
        print(f'-- {name}')
