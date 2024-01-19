import time
from django.shortcuts import render
from django.http import HttpResponse


# Create your views here.
# def index(request):
#     return HttpResponse(f'it works good {time.localtime()}')
#
#
# def index2(request, *args, **kwargs):
#     return HttpResponse(f'Response with {args} and {kwargs}')
#
#
# def department_1_details(request):
#     return HttpResponse(f"Department 1")
#
#
# def department_2_details(request):
#     return HttpResponse(f"Department 2")
#
#
#
#
# def department_list(request):
#     pass
#
#
# def department_create(request):
#     pass
def index(request, *args, **kwargs):
    return HttpResponse(f"It works with args={args} and kwargs={kwargs}")


def department_details(request, pk):
    return HttpResponse(f"Response department by id: {pk}")


def department_details_by_name(request, name):
    return HttpResponse(f"Response department by name: {name}")
