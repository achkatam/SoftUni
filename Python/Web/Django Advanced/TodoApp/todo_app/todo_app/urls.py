from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path("admin/", admin.site.urls),
    path("api/", include([
        path("auth/", include("todo_app.todos_auth.urls")),
        path("todos/", include("todo_app.todos.urls")),
    ])),
]