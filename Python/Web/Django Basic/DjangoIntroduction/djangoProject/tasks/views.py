from django.shortcuts import render
from django.http import HttpResponse
from .models import Task

# Create your views here.
"""
Function based view:
1. A function that has one or more params
2. Returns a response
"""


# def index(request):
#     return http.HttpResponse("it works!")

# def index(request):
#     tasks = Task.objects.all()
#
#     if not tasks:
#         return HttpResponse("<h1>No tasks!!!</h1>")
#
#     result = []
#
#     for task in tasks:
#         result.append(f"""
#         <li>
#          <h2>{task.title}</h2>
#          <p>{task.description}</p>
#         </li>""")
#
#         ul = f"<ul>{''".join(result)}</ul>"
#
#         content = f"""
#         <h1>{len(tasks)} Tasks </h1>
#         {ul}"""
#
#     # return HttpResponse(content)
#     return render(request, "tasks/index.html")

def index(request):
    print("In the view")
    title_filter = request.GET.get("title_filter", "")
    tasks = Task.objects.all()

    if title_filter:
        tasks = tasks.filter(title__icontains=title_filter.lower())

    context = {
        "title": "The task app!!!",
        "tasks_list": tasks,
        "tasks_count": tasks.count(),
        "title_filter": title_filter,
    }
    return render(request, "tasks/index.html",
                  context)
