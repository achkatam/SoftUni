from django.contrib.auth import get_user_model
from rest_framework import generics as api_views, permissions
from rest_framework.authtoken import views as api_token_views

from todo_app.todos_auth.serializers import UserCreateSerializer

UserModel = get_user_model()


class CreateUserApiView(api_views.CreateAPIView):
    serializer_class = UserCreateSerializer
    queryset = UserModel.objects.all()
    permission_classes = [permissions.AllowAny]


class LoginApiView(api_token_views.ObtainAuthToken):
    permission_classes = [permissions.AllowAny]


class LogoutApiView:
    permission_classes = [permissions.IsAuthenticated]
