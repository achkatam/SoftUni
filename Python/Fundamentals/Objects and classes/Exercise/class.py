from numpy import mean


class Class:
    def __init__(self, class_name):
        self.class_name = class_name
        self.students = []
        self.grades = []

    __students_count = 22

    def add_student(self, student_name, student_grade):
        if Class.__students_count >= len(self.students):
            self.students.append(student_name)
            self.grades.append(student_grade)

    def get_average_count(self):
        avg = mean(self.grades)

        return round(avg, 2)

    def __repr__(self):
        output = (f"The students in {self.class_name}: {', '.join(st for st in self.students)}."
                  f" Average grade: {self.get_average_count()}")

        return output


a_class = Class("11B")
a_class.add_student("Peter", 4.80)
a_class.add_student("George", 6.00)
a_class.add_student("Amy", 3.50)

print(a_class)
