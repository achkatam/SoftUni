from django.http import HttpResponse
from django.urls import path

urlpatterns = (
    path("", lambda r: HttpResponse("<h1>It works</h1>"), name="index"),
)
