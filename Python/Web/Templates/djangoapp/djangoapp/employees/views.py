import datetime
import random

from django.shortcuts import render


class Person:
    def __init__(self, first_name, last_name, age=None):
        self.first_name = first_name
        self.last_name = last_name
        self.age = age

    @property
    def full_name(self):
        return f"{self.first_name} {self.last_name}"


# Create your views here.
def index(request):
    context = {
        "title": "Employees List",
        "newEmployee": "Angel",
        "new employee": "Angel",  # invalid
        "new_employee": "Angel",  # invalid
        "new,employee": "Angel",  # invalid
        "123": "Angel",  # invalid
        "123asd": "Angel",  # valid

        "person": {
            "first_name": "Angel",
            "last_name": "Matev",
        },
        "person_obj": Person("Angel"
                             , "Matev"),
        "names_list": {"Angel", "Steve", "Sammy"},
        "ages": [random.randrange(1, 90) for _ in range(10)],
        "ages_empty": [],
        "date": datetime.date.today(),
        "get_params": request.GET,
    }
    # print(context["person"]["first_name"])
    # print(context["person"].items())

    return render(request, "employees/index.html", context)


def employee_details(request, pk):
    context = {
        "pk": pk,
    }
    return render(request, "employees/details.html", context)
