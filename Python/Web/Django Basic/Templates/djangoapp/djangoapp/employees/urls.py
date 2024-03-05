from django.urls import path
from djangoapp.employees import views

urlpatterns = [
    path("", views.index, name="index"),
    path("employees/<int:pk>", views.employee_details, name="employee_details")
]
