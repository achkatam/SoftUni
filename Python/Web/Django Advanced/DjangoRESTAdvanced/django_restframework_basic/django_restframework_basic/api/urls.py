from django.urls import path

from django_restframework_basic.api.views import api_list_books, BookListCreateApiView, BookUpdateApiView, api_list_authors

urlpatterns = (
    path("books/", BookListCreateApiView.as_view(), name="api_list_create_books"),
    path("books/<int:pk>", BookUpdateApiView.as_view(), name="api_book_update"),
    path("authors/", api_list_authors, name="api_list_authors"),
)
