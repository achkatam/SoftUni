from django.urls import path

from django_restframework_advanced.web.views import IndexView

urlpatterns = (
    path("", IndexView.as_view(), name="index"),
)
