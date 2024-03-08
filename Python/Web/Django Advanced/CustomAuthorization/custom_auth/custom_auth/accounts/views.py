from django.contrib.auth import views as auth_views, get_user_model
from django.contrib.auth import forms as auth_forms
from django.views import generic as views

from django.urls import reverse_lazy

UserModel = get_user_model()


# Create your views here
class LoginUserView(auth_views.LoginView):
    template_name = "accounts/login.html"

    def get_default_redirect_url(self):
        return reverse_lazy("index")


class AccountUserCreationForm(auth_forms.UserCreationForm):
    class Meta(auth_forms.UserCreationForm.Meta):
        model = UserModel
        fields = auth_forms.UserCreationForm.Meta.fields


class RegisterUserView(views.CreateView):
    form_class = AccountUserCreationForm
    template_name = "accounts/register.html"
    success_url = reverse_lazy("index")
