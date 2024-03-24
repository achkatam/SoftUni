from django.contrib import admin

from todo_app.todos.models import Todo, Category


# Register your models here.
@admin.register(Todo)
class TodoAdmin(admin.ModelAdmin):
    list_display = ("pk", "title", "state", "category_name")

    def category_name(self, obj):
        return obj.category.name


@admin.register(Category)
class TodoAdmin(admin.ModelAdmin):
    list_display = ("pk", "name")
