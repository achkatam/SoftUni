from django import forms
from forms_advanced.web.models import Person
from django.forms import modelform_factory


class PersonForm(forms.ModelForm):
    class Meta:
        model = Person
        fields = "__all__"

        # Not the best practice
        # labels = {
        #     "first_name": "First Name:",
        # }
        #
        # error_messages = {
        #     "first_name": {
        #         "required": "Please enter a first name.",
        #         "min_length": "First name must be at least 1 character long.",
        #     }
        # }


PersonForm2 = modelform_factory(Person, fields="__all__")
