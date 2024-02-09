import random
from django.views import generic as views
from datetime import datetime
from django.shortcuts import render
from django.http import HttpResponseNotAllowed


def perform_always():
    # It's error prob if you have to add this method to every single method
    # Better in class and just inherit the class
    pass


class BaseViews(views.View):
    def dispatch(self, request, *args, **kwargs):
        # Just inherit the class, so you have access to perform_always() all the time
        perform_always()

        return super().dispatch(request, *args, **kwargs)


# Create your views here.
def index(request):  # Too explicit
    perform_always()

    if request.method == "POST":
        # do some "post" logic
        pass
    elif request.method == "GET":
        # do some "get" logic
        pass

    # Do some business logic

    return render(request, 'web/index.html')


class IndexRawView(views.View):
    def dispatch(self, request, *args, **kwargs):
        if random.random() < 0.5:
            return HttpResponseNotAllowed(["get"])

        # check permissions of users
        return super().dispatch(request, *args, **kwargs)

    def get(self, request):
        # perform get logic
        return render(request, "web/index.html")

    def post(self, request):
        # perform post logic
        pass


class IndexView(views.TemplateView):
    # static template
    template_name = "web/index.html"

    # dynamic template
    # def get_template_names(self):

    # "context" with static data, i.e. no DB calls
    extra_context = {
        "title": "This is the title, buddy!",
        "extra_context": "This is the extra context",
        "static_time": datetime.now(),
    }

    # "context" with static data, i.e. has DB calls and etc.
    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)

        context["dynamic_time"] = datetime.now()

        return context
