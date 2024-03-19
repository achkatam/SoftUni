from django.urls import path
from rest_framework.authtoken import views as token_views

from django_restframework_advanced.api.views import api_list_books, BookListCreateApiView, BookUpdateApiView, \
    api_list_authors, api_list_author

urlpatterns = (
    path("books/", BookListCreateApiView.as_view(), name="api_list_create_books"),
    path("books/<int:pk>", BookUpdateApiView.as_view(), name="api_book_update"),
    path("authors/", api_list_authors, name="api_list_authors"),
    path("authors/<int:pk>", api_list_author, name="api_list_author"),
)
