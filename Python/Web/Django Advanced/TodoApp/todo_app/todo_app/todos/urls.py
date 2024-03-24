from django.urls import path

from todo_app.todos.views import TodoListCreateApiView, CategoriesListApiView, TodoDetailsApiView

urlpatterns = (
    path("", TodoListCreateApiView.as_view(), name="api_list_create_todos"),
    path("<int:pk>/", TodoDetailsApiView.as_view(), name="api_details_todo"),
    path("categories/", CategoriesListApiView.as_view(), name="api_list_categories"),
)
