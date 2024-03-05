from django import forms

from djangoProject.profile.models import Profile


class ProfileWebForm(forms.ModelForm):
    class Meta:
        model = Profile
        fields = ['username', 'email', "age", 'password']
        widgets = {
            'password': forms.PasswordInput(render_value=True),
        }
