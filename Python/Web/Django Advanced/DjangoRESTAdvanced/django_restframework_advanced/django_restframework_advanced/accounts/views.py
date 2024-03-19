from django.contrib.auth import get_user_model
from django.shortcuts import render

from rest_framework import views as api_views
from rest_framework import generics as api_generic_views
from rest_framework.authtoken import views as token_views

from django_restframework_advanced.accounts.serializers import UserRegisterSerializer

UserModel = get_user_model()


# Create your views here.
# Account
class RegisterApiView(api_generic_views.CreateAPIView):
    queryset = UserModel.objects.all()
    serializer_class = UserRegisterSerializer


class LoginApiView(token_views.ObtainAuthToken):
    pass

# # Not needed. Handled on the client-side
# class LogoutApiView(api_generic_views.CreateAPIView):
# pass
