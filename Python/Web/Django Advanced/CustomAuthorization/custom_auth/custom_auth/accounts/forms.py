from django import forms
from django.contrib.auth import forms as auth_forms
from django.contrib.auth import get_user_model

from custom_auth.accounts.models import Profile

UserModel = get_user_model()


class AccountUserChangeForm(auth_forms.UserChangeForm):
    class Meta(auth_forms.UserChangeForm.Meta):
        model = UserModel
        fields = "__all__"


class AccountUserCreationForm(auth_forms.UserCreationForm):
    # Adds the following field/s to the register form
    age = forms.IntegerField()

    class Meta(auth_forms.UserCreationForm.Meta):
        model = UserModel
        fields = (UserModel.USERNAME_FIELD,)
        # fields = auth_forms.UserCreationForm.Meta.fields

    def save(self, commit=True):
        user = super().save(commit=commit)

        profile = Profile(
            user=user,
            age=self.cleaned_data["age"],
        )

        if commit:
            profile.save()

        return user
