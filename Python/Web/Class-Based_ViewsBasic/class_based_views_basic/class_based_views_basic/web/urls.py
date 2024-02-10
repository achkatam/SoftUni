from django.urls import path
from class_based_views_basic.web.views import index, IndexRawView, IndexView, TodoCreateView, \
    TodoDetailsView

urlpatterns = (
    path("", IndexView.as_view(), name="index"),
    path("raw/", index, name="index raw"),
    path("view/", IndexRawView.as_view(), name="view"),
    path("initkwargs/", IndexView.as_view(template_name="web/index.html")),

    path("todos/create/", TodoCreateView.as_view(), name="todos_create"),
    path("todos/<int:pk>", TodoDetailsView.as_view(), name="todos_details"),

)
