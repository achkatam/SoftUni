from django.urls import path

from django_restframework_basic.web.views import IndexView

urlpatterns = (
    path("", IndexView.as_view(), name="index"),
)
