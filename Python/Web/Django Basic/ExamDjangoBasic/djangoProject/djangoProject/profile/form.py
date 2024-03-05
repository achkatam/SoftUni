from django import forms

from djangoProject.profile.models import Profile


class ProfileForm(forms.ModelForm):
    class Meta:
        model = Profile
        fields = ['username', 'email', 'first_name', 'last_name', 'profile_pic', 'password']
        widgets = {
            'password': forms.PasswordInput(render_value=True),
        }
