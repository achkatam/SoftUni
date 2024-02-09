from django.shortcuts import render
from django import views


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


class IndexView(views.View):
    def get(self, request):
        # perform get logic
        return render(request, "web/index.html")

    def post(self, request):
        # perform post logic
        pass
