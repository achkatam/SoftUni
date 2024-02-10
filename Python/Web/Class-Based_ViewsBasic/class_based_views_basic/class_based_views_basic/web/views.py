import random
from django.views import generic as views
from datetime import datetime
from django.shortcuts import render
from django.http import HttpResponseNotAllowed
from class_based_views_basic.web.models import Todo
from class_based_views_basic.web.forms import TodoBaseForm
from django.urls import reverse_lazy, reverse


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

        context["todo_list"] = Todo.objects.all()

        return context


class TodoCreateView(views.CreateView):
    model = Todo
    fields = "__all__"
    template_name = "web/create_todo.html"

    # Static way
    # success_url = reverse_lazy("index")

    # Dynamic way
    def get_success_url(self):
        return reverse("todos_details", kwargs={"pk": self.object.pk})

    # Static way
    # form_class = TodoBaseForm

    # Dynamic way is used when you want to use if statements
    def get_form_class(self):
        # return TodoBaseForm
        return super().get_form_class()

    def get_form(self, form_class=None):
        form = super().get_form(form_class=form_class)

        form.fields["deadline"].widget.attrs["type"] = "date"

        return form


class TodoDetailsView(views.DetailView):
    model = Todo
    template_name = "web/details_todo.html"
