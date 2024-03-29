from django.db import models
from .enums import Genre


# Create your models here.

class Author(models.Model):
    name = models.CharField(
        max_length=22,
    )


class Book(models.Model):
    title = models.CharField(
        max_length=20,
    )

    pages = models.IntegerField(
        default=0,
    )

    description = models.TextField(
        max_length=100,
        default="",
    )

    genre = models.CharField(
        max_length=max(len(choice.value) for choice in Genre),
        choices=[(genre.value, genre.value) for genre in Genre]
    )

    author = models.ForeignKey(
        Author,
        on_delete=models.CASCADE,
    )
