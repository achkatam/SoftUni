from django.contrib.auth import views as auth_views


class LoginUserView(auth_views.LoginView):
    template_name = "accounts/login.html"


class RegisterUserView:
    pass
