import json

from django.shortcuts import render, redirect
from django.http import HttpResponse, JsonResponse, HttpResponseNotFound, Http404


# Create your views here.
def index_no_template(request, *args, **kwargs):
    content = (f"It works with: <br/>"
               f"args={args} and kwargs={kwargs},<br/>"
               f"path={request.path},<br/>"
               f"method={request.method}, <br/>"
               f"user={request.user}")
    return HttpResponse(content)


def index(request, *args, **kwargs):
    context = {
        "title": "Request data",
        "args": args,
        "kwargs": kwargs,
        "path": request.path,
        "method": request.method,
        "user": request.user,
    }
    return render(request, 'core/index.html', context)


def redirect_to_softuni(request):
    return redirect("https://softuni.bg/")


def redirect_to_index(request):
    return redirect("index_no_params")


def redirect_to_index_with_params(request):
    return redirect("index_with_pk_and_slug", pk=19, slug="peter")


def raise_error(request):
    return HttpResponseNotFound("Simply not found")


def raise_error404(request):
    raise Http404


def index_json(request, *args, **kwargs):
    content = json.dumps(
        {
            "args": args,
            "kwargs": kwargs,
            "path": request.path,
            "method": request.method,
            "user": str(request.user),
        }
    )
    return JsonResponse(content,
                        content_type="application/json",
                        safe=False)


def department_details(request, pk):
    return HttpResponse(f"Response department by id: {pk}")


def department_details_by_name(request, name):
    return HttpResponse(f"Response department by name: {name}")
