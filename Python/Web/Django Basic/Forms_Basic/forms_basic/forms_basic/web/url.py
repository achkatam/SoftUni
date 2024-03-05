from django.urls import path
from . import views

urlpatterns = [
    path("", views.index, name="index"),
    path("modelforms/", views.index_models, name="index_models"),
    path("modelforms/<int:id>", views.update_employee, name="update_employee"),
]
