import random

from django.shortcuts import render

# Create your views here.
motorcycles = [
    "https://imgs.search.brave.com/dOOB2bdMiX-fIkqscB7VG25-BdFbEg3eJ8gC9ehUtTM/rs:fit:860:0:0/g:ce/aHR0cHM6Ly91bHRp/bWF0ZW1vdG9yY3lj/bGluZy5jb20vd3At/Y29udGVudC91cGxv/YWRzLzIwMjEvMDcv/MjAyMi1LVE0tMzAw/LVhDLVctVFBJLUVy/emJlcmdyb2Rlby1m/aXJzdC1sb29rLWxp/bWl0ZWQtZWRpdGlv/bi1oYXJkLWVuZHVy/by1tb3RvcmN5Y2xl/LTUtNjk2eDQ2NC5q/cGc",
    "https://imgs.search.brave.com/8tJpVtmO2VSmWJnGA0HVGxMZ0S5jo0-XVSb2pfOUoGw/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9tb3Rv/Y3Jvc3NoaWRlb3V0/LmNvbS93cC1jb250/ZW50L3VwbG9hZHMv/MjAyMi8xMi8yMDA4/LUtUTS0yMDAtWENX/LmpwZw",
]

brands = (
    "ktm",
    "husqvarna",
)


def index(request):
    index = random.randint(0, len(motorcycles) - 1)
    context = {
        "ktm_image": motorcycles[index],
        "brand": brands[index],
        "numbers": [x + 1 for x in range(0, 20)],
    }

    return render(request, 'web/index.html', context)


def about(request):
    return render(request, "web/about.html")


def visualize_bootstrap(request):
    context = {
        "has_bootstrap": request.GET.get("has_bootstrap", False),
    }

    return render(request, "web/bootstrap.html", context)
