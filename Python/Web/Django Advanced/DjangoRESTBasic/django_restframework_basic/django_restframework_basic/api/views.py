import time

from django.shortcuts import render, redirect
from rest_framework.decorators import api_view
from rest_framework.response import Response

from django_restframework_basic.api.models import Book

from rest_framework import status
from django.views import generic as views
from rest_framework import views as api_views
from rest_framework import generics as api_generic_views

from .serializers import BookSerializer

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
def api_list_books(request):
    book_list = Book.objects.all()

    serializer = BookSerializer(book_list, many=True)

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


class BookListApiView( api_views.APIView):
    # queryset = Book.objects.all()
    # serializer_class = BookSerializer

    def get(self, request):
        time.sleep(1)
        book_list = Book.objects.all()

        serializer = BookSerializer(book_list, many=True)

        json = serializer.data

        return Response(data=json)

    def post(self, request):
        serializer = BookSerializer(data=request.data)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data, status=status.HTTP_201_CREATED)


class BookUpdateApiView(api_generic_views.UpdateAPIView, api_views.APIView):
    # queryset = Book.objects.all()
    serializer_class = BookSerializer

    def get_object(self, pk):
        return Book.objects \
            .filter(pk=pk) \
            .first()

    def get(self, request, pk):
        serializer = BookSerializer(instance=self.get_object(pk))

        json = serializer.data

        return Response(data=json)

    def put(self, request, pk):
        book = self.get_object(pk)

        serializer = BookSerializer(data=request.data,
                                    instance=self.get_object(pk))

        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data, status=status.HTTP_200_OK)
