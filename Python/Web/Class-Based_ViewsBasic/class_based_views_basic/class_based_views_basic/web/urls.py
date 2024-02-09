from django.urls import path
from class_based_views_basic.web.views import index


urlpatterns = (
    path("", index, name="index"),
)