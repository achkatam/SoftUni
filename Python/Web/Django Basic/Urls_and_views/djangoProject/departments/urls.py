from django.urls import path
from . import views

urlpatterns = [
    # path('index/', views.index),
    # path('', views.index2),
    # path("departments/1", views.department_1_details),
    # path("departments/2", views.department_2_details),

    # Always str param is after the int
    path("<int:pk>/", views.department_details),
    path("<str:name>/", views.department_details_by_name),
]
