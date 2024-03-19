from django.contrib import admin

from django_restframework_advanced.api.models import Book, Author


# Register your models here.
@admin.register(Book)
class BookAdmin(admin.ModelAdmin):
    list_display = ("title", "author", "genre",)


@admin.register(Author)
class AuthorAdmin(admin.ModelAdmin):
    list_display = ("name",)
