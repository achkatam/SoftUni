command = input()
students_dict = {}


while ":" in command:

    tokens = command.split(":")

    name, id, course = tokens[0], tokens[1], tokens[2]

    if course not in students_dict:
        students_dict[course] = {}

    students_dict[course][id] = name

    command = input()

course_looked_for = " ".join(command.split('_'))


for key, value in students_dict.items():
    if key == course_looked_for:
        for id, name in value.items():
            print(f'{name} - {id}')
