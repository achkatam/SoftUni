from django.shortcuts import render, redirect
from .forms import DemoForm, EmployeeForm, EmployeeNormalForm, Employee
from django.http import HttpResponse


def update_employee(request, id):
    employee = Employee.objects.get(pk=id)
    if request.method == "GET":
        form = EmployeeForm(instance=employee)
    else:
        form = EmployeeForm(request.POST, instance=employee)
        if form.is_valid():
            form.save()

            return redirect("index_models")

    context = {
        "form": form,
        "employee": employee,
    }

    return render(request, "web/employee_details.html", context)


def index_models(request):
    form = EmployeeForm(request.POST or None)

    if request.method == "POST":
        if form.is_valid():
            form.save()

            return redirect("index_models")

    context = {
        "employee_form": form,
        "employee_list": Employee.objects.all(),
    }

    return render(request, "web/modelform_index.html", context)


def index(request):
    # if request.method == "POST":
    form = DemoForm(request.POST or None)

    if request.method == "POST":
        if form.is_valid():
            print(form.cleaned_data["first_name"])
            return redirect("index")

    context = {
        "employee_form": form
    }
    return render(request, "web/index.html", context)

# Create your views here.
# def index(request):
#     if request.method == "POST":
#         context = {
#             "employee_form": EmployeeForm(),
#         }
#
#         return render(request, "web/index.html", context)
#
#     else:
#         form = EmployeeForm(request.POST)
#         if form.is_valid():
#             print(form.cleaned_data["first_name"])
#
#             redirect("index")
#         else:
#             context = {
#                 "employee_form": form,
#             }
#
#         return render(request, "web/index.html", context)
