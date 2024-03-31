from django.contrib.auth import get_user_model
from django import forms
from django.shortcuts import render
from django.views import generic as views

UserModel = get_user_model()


# Create your views here.
def show_users(request):
    users_list = UserModel.objects.all()
    context = {
        'users_list': users_list,
    }

    return render(request, 'web/users.html', context)


# No sense to be tested
class CreateUserForm(forms.ModelForm):
    class Meta:
        model = UserModel
        fields = ['username', 'email', 'password']


class ListUsersView(views.ListView):
    model = UserModel
    template_name = 'web/users.html'

    def get_queryset(self):
        queryset = super().get_queryset()
        queryset = queryset.oderder_by('date_joined')
        return queryset
