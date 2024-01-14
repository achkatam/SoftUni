from django.contrib import admin
from .models import Task


# Register your models here.

# admin.site.register(Task)
@admin.register(Task)
class TaskAdmin(admin.ModelAdmin):
    list_display = ('id', 'title', 'done')
    list_filter = ('done',)