import time

from django.shortcuts import render, redirect
from rest_framework.decorators import api_view
from rest_framework.response import Response

from django_restframework_advanced.api.models import Book, Author
from django.views import generic as views

from rest_framework import status, permissions
from rest_framework import views as api_views
from rest_framework import generics as api_generic_views
from rest_framework.authtoken import views as token_views

from .permissions import IsOwnerPermission
from .serializers import BookForListSerializer, AuthorForListSerializer, BookForCreateSerializer, \
    BookForUpdateSerializer

"""
Function based views examples
"""


# Create your views here.
def list_books(request):
    pass
    # book_list = Book.objects.all()
    #
    # context = {
    #     "book_list": book_list,
    # }
    #
    # return render(request, "...", context)


@api_view(http_method_names=["GET"])
def api_list_authors(request):
    author_list = Author.objects.all()

    serializer = AuthorForListSerializer(author_list, many=True)

    json = serializer.data

    return Response(data=json)


@api_view(http_method_names=["GET"])
def api_list_author(request, pk):
    author = (Author.objects.filter(pk=pk)
              .first())

    serializer = AuthorForListSerializer(many=False, instance=author)

    json = serializer.data

    return Response(data=json)


@api_view(http_method_names=["GET"])
def api_list_books(request):
    book_list = Book.objects.all()

    serializer = BookForListSerializer(book_list, many=True)

    json = serializer.data

    return Response(data=json)


"""
Class based views examples
"""


class BookListView(views.View):
    def get(self, request):
        return render(request, template_name="")

    def post(self, request):
        form = MyForm(request.POST)

        if form.is_valid():
            form.save()
            return redirect("")

        return render(request, template_name="", context=None)


# class BookListApiView(api_views.APIView):
#     # queryset = Book.objects.all()
#     # serializer_class = BookForListSerializer
#
#     def get(self, request):
#         time.sleep(1)
#         book_list = Book.objects.all()
#
#         serializer = BookForListSerializer(book_list, many=True)
#
#         json = serializer.data
#
#         return Response(data=json)
#
#     def post(self, request):
#         serializer = BookForListSerializer(data=request.data)
#         if serializer.is_valid():
#             serializer.save()
#             return Response(serializer.data, status=status.HTTP_201_CREATED)
class BookListCreateApiView(api_generic_views.ListCreateAPIView):
    queryset = Book.objects.all()
    permission_classes = [
        IsOwnerPermission,
        permissions.IsAuthenticatedOrReadOnly,
    ]

    list_serializer_class = BookForListSerializer
    create_serializer_class = BookForCreateSerializer

    serializer_class = list_serializer_class

    # def get_permissions(self):
    #     if self.request.method == "POST":
    #         return [IsAdmin]
    #     return [permissions.IsAuthenticated]

    # override
    def get_serializer_class(self):
        if self.request.method == "POST":
            return self.create_serializer_class
        return self.list_serializer_class

        # Mostly used in Django

    # For filtering override the queryset
    # def get_queryset(self):
    #     queryset = super().get_queryset()

    # apply filters
    # Get the author name from the query parameters
    # author_name = self.request.query_params.get('author', None)
    # title_pattern = self.request.query_params.get('title', None)
    #
    # if author_name:
    #     queryset = queryset.filter(author__name=author_name)
    #
    # if title_pattern:
    #     queryset = queryset.filter(title__icontains=title_pattern)
    #
    # return queryset

    def filter_queryset(self, queryset):
        queryset = super().filter_queryset(queryset)

        # Get the author name from the query parameters
        author_name = self.request.query_params.get('author', None)
        title_pattern = self.request.query_params.get('title', None)

        if author_name:
            queryset = queryset.filter(author__name=author_name)

        if title_pattern:
            queryset = queryset.filter(title__icontains=title_pattern)

        return queryset


class BookUpdateApiView(api_generic_views.UpdateAPIView, api_views.APIView):
    # queryset = Book.objects.all()
    serializer_class = BookForUpdateSerializer
    permission_classes = [permissions.IsAdminUser]

    def get_object(self, pk):
        return Book.objects \
            .filter(pk=pk) \
            .first()

    def get(self, request, pk):
        serializer = BookForListSerializer(instance=self.get_object(pk))

        json = serializer.data

        return Response(data=json)

    def put(self, request, pk):
        book = self.get_object(pk)

        serializer = BookForUpdateSerializer(data=request.data,
                                             instance=self.get_object(pk))

        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data, status=status.HTTP_200_OK)
