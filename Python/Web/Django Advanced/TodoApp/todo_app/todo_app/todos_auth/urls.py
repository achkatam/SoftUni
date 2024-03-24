from django.urls import path

from todo_app.todos_auth.views import CreateUserApiView, LoginApiView

urlpatterns = (
    path("register/", CreateUserApiView.as_view(), name="api_create_user"),
    path("login/", LoginApiView.as_view(), name="api_login"),
    # path("logout/", LogoutApiView.as_view(), name="api_logout"),
)
