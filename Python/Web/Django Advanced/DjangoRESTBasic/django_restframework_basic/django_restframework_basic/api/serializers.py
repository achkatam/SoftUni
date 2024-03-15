from rest_framework import serializers

from django_restframework_basic.api.models import Book


class BookSerializer(serializers.ModelSerializer):
    class Meta:
        model = Book
        fields = ("pk", "title", "author", "genre",)
