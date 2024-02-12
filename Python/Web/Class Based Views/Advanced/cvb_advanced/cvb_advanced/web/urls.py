from django.urls import path

from cvb_advanced.web.views import create_todo, CreateTodoView, ListTodoView, DetailTodoView

urlpatterns = [
    # path("create/", create_todo),
    path("", ListTodoView.as_view(), name="todos_list"),

    path("create/", CreateTodoView.as_view(), name="todos_create"),

    path("<int:pk>/", DetailTodoView.as_view(), name="todos_detail"),
    path("<slug:slug>/", DetailTodoView.as_view(), name="todos_detail"),
    path("<int:pk>/<slug:slug>/", DetailTodoView.as_view(), name="todos_detail"),
]
