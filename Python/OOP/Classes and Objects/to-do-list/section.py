from project.task import Task
from typing import List


class Section:
    def __init__(self, name):
        self.name = name
        self.tasks: List[Task] = []

    def add_task(self, new_task: Task):
        if new_task in self.tasks:
            return f'Task is already in the section {self.name}'

        self.tasks.append(new_task)
        return f'Task {new_task.details()} is added to the section'

    def complete_task(self, task_name):
        # if task_name not in self.tasks:
        #     return f'Could not find task with the name {task_name}'
        curr_task: Task

        for task in self.tasks:
            if task.name == task_name:
                curr_task = task
                curr_task.completed = True
                return f'Completed task {task_name}'

    def clean_section(self):
        # TODO all completed task to be remove
        # cnt = 0
        # for task in self.tasks:
        #     if task.completed:
        #         self.tasks.remove(task)
        #         cnt += 1

        completed_tasks = [task for task in self.tasks if not task.completed]
        cnt = len(self.tasks) - len(completed_tasks)
        self.tasks = completed_tasks
        return f'Cleared {cnt} tasks.'

    def view_section(self):
        string_builder = f"Section {self.name}:\n"
        for task in self.tasks:
            string_builder += f'{task.details()}\n'

        return string_builder


task = Task("Make bed", "27/05/2020")
print(task.change_name("Go to University"))
print(task.change_due_date("28.05.2020"))
task.add_comment("Don't forget laptop")
print(task.edit_comment(0, "Don't forget laptop and notebook"))
print(task.details())
section = Section("Daily tasks")
print(section.add_task(task))
second_task = Task("Make bed", "27/05/2020")
section.add_task(second_task)
print(section.clean_section())
print(section.view_section())
