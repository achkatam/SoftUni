from django import forms
from .models import Employee


class DemoForm(forms.Form):
    first_name = forms.CharField(
        max_length=50,
        required=False,
        label="First Name",
        widget=forms.TextInput(
            # Bad practice but for example
            attrs={
                "placeholder": "Enter your first name",
                "class": "form-control",
            }, )
    )

    last_name = forms.CharField(
        max_length=50,
        required=False,
        label="Last Name",
    )

    age = forms.IntegerField(
        required=False,
        label="Age",
    )

    # EmailField - not significant difference when visualized on pc
    # but visualized on mobile device
    # @
    # https://
    # .com
    # @gmail.com/ for android
    email = forms.EmailField(
        required=False,
        label="Email",
    )

    # Customize using widget
    comment = forms.CharField(
        required=False,
        label="Comment",
        widget=forms.Textarea,
    )

    interests = forms.ChoiceField(
        choices=(
            (" ", " "),
            ("sports", "Sports"),
            ("music", "Music"),
            ("movies", "Movies"),
            ("travel", "Travel"),
        ),
        required=False,
        label="Interests",
    )

    choices = (
        ("sports", "Sports"),
        ("music", "Music"),
        ("movies", "Movies"),
        ("travel", "Travel"),
    )

    interests2 = forms.CharField(
        widget=forms.Select(choices=choices),
        required=False,
        label="Interests2",
    )

    interests3 = forms.CharField(
        widget=forms.RadioSelect(choices=choices),
        required=False,
        label="Interests3",
    )

    interests4 = forms.CharField(
        widget=forms.CheckboxSelectMultiple(choices=choices),
        required=False,
        label="Interests4",
    )


# Too much confusion and code repetition
class EmployeeNormalForm(forms.Form):
    first_name = forms.CharField(
        max_length=50,
        required=False,
    )

    last_name = forms.CharField(
        max_length=50,
        required=False,
    )

    role = forms.IntegerField(
        widget=forms.RadioSelect(choices=Employee.ROLES),
        required=False,
    )


class EmployeeForm(forms.ModelForm):
    # Custom field
    # department2 = forms.CharField()

    class Meta:
        model = Employee
        fields = "__all__"

        labels = {
            "first_name": "First Name",
            "last_name": "Last Name",
            "role": "Role",
        }

        widgets = {
            "role": forms.RadioSelect,
        }