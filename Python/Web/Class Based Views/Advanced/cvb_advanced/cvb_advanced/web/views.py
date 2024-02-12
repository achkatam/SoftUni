import json
import random

from .models import Todo
from django.shortcuts import render
from django.http import HttpResponse
from django.urls import reverse_lazy
from django.views import generic as views
from django import forms

"""
CRUD:
1. Create
    -Create View
2. Read (details, list)
    - DetailView
    - ListView
3. Update
    - UpdateView
4. Delete
    - DeleteView
"""


# Create your views here.
# def index(request):
#     context = {
#         "todo_list": [t.title for t in Todo.objects.all()],
#     }
#
#     return HttpResponse(json.dumps(context))
# {ACTION}{ENTITY}{View}
class CreateTodoView(views.CreateView):
    model = Todo  # or queryset
    fields = ["title", "description", "is_done"]  # or "exclude or "form_class"

    template_name = "web/create_todo.html"
    success_url = reverse_lazy("todos_list")


class FilterTodoForm(forms.Form):
    title_pattern = forms.CharField(
        max_length=Todo.MAX_TITLE_LENGTH,
        required=False,
    )

    is_done = forms.BooleanField(
        required=False,
    )


class DetailTodoView(views.DetailView):
    model = Todo
    template_name = "web/detail_todo.html"
    slug_field = "slug"
    query_pk_and_slug = True

    def get_queryset(self):
        queryset = super().get_queryset()

        tenant = self.request.GET.get("tenant", None)
        if tenant is not None:
            queryset = queryset.filter(tenant=tenant)

        return queryset


class ListTodoView(views.ListView):
    model = Todo
    # queryset = Todo.objects.all()
    template_name = "web/list_todo.html"

    # Static way for pagination
    paginate_by = 3

    # Dynamic way for pagination
    # def get_paginate_by(self, queryset):
    #     return random.randint(1, 14)

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)

        context["title"] = "Todos List"

        context["filter_form"] = FilterTodoForm(
            initial={
                "title_pattern": self.get_title_pattern(),
            },
        )

        return context

    def get_queryset(self):
        queryset = super().get_queryset()

        queryset = self.apply_filter(queryset)
        #     queryset = Todo.objects.all()
        # queryset = queryset.filter(title__icontains="wash")
        # queryset = queryset.filter(description__icontains="lube")

        return queryset

    def apply_filter(self, queryset):
        title_pattern = self.get_title_pattern()
        if title_pattern:
            queryset = queryset.filter(title__icontains=title_pattern)

        # is_done = self.get_is_done_filter()
        # if is_done is not None:
        #     queryset = queryset.filter(is_done=is_done)

        return queryset

    def get_title_pattern(self):
        return self.request.GET.get("title_pattern", None)

    def get_is_done_filter(self):
        return self.request.GET.get("is_done", None) == "on"


def create_todo(request):
    pass
