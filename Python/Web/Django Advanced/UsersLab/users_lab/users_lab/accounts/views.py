from django.contrib.auth import views as auth_views, authenticate, login, get_user_model, logout
from django.contrib.auth import forms as auth_forms
from django.contrib.auth.forms import AuthenticationForm
from django.shortcuts import render, redirect
from django.views import generic as views
from django.urls import reverse_lazy, reverse

from users_lab.accounts.form import UserCreateForm

UserModel = get_user_model()


# "authenticate(requests, **credentials)" -> returns the user if credentials match
# "login(requests, user)" -> attaches a cookie for the authenticated user
class LoginUserView(auth_views.LoginView):
    template_name = "accounts/login_user.html"

    def get_success_url(self):
        return reverse("index")


class RegisterUserView(views.CreateView):
    form_class = UserCreateForm
    template_name = "accounts/register_user.html"
    success_url = reverse_lazy("index")

# Custom LoginView
# class LoginUserView(views.View):
#     form_class = auth_forms.AuthenticationForm
#
#     def get(self, request, *args, **kwargs):
#         context = {
#             "form": self.form_class(),
#         }
#
#         return render(request, "accounts/login_user.html", context)
#
#     def post(self, request, *args, **kwargs):
#         username, password = request.POST["username"], request.POST["password"]
#
#         user = authenticate(username=username, password=password)
#         print(user)
#
#         if user is not None:
#             # Add user to the session
#             login(request, user)
#             return redirect("index")
