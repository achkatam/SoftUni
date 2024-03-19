from django.urls import path

from django_restframework_advanced.accounts.views import LoginApiView, RegisterApiView

urlpatterns = [
    path("token/", LoginApiView.as_view(), name="obtain_token"),
    path("register/", RegisterApiView.as_view(), name="register_user"),
]
