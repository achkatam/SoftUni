from math import ceil

n_students = int(input())
n_lectures = int(input())
bonus_points = int(input())

the_student: dict = {}
for student in range(n_students):
    student_attendance = int(input())
    total_points = student_attendance / n_lectures * (5 + bonus_points)

    the_student[total_points] = student_attendance

max_bonus = max(the_student, key=the_student.get)
lectures = the_student[max_bonus]

print(f"Max Bonus: {ceil(max_bonus)}.")
print(f"The student has attended {lectures} lectures.")
