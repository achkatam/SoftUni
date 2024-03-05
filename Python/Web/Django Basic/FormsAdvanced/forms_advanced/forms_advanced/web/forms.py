from django import forms
from forms_advanced.web.models import Person
from django.forms import modelform_factory, modelformset_factory
from crispy_forms.helper import FormHelper
from django.urls import reverse
from crispy_forms.layout import Submit


class PersonForm(forms.ModelForm):
    class Meta:
        model = Person
        fields = "__all__"

    def __init__(self, *args, **kwargs):
        if "user" in kwargs:
            self.user = kwargs.pop("user")

        super().__init__(*args, **kwargs)

        self.helper = FormHelper()
        self.helper.form_id = "id-exampleForm"
        self.helper.form_class = "blueForms"
        self.helper.form_method = "post"
        self.helper.form_action = reverse("create_person")
        self.helper.add_input(Submit("submit", "Create Person"))

    def clean(self, *args, **kwargs):
        cleaned_data = super().clean(*args, **kwargs)
        print(cleaned_data)
        return cleaned_data

    # def clean_first_name(self):
    #     pass


class ReadonlyFieldsFormMixin:
    readonly_fields = ()

    def _mark_readonly_fields(self):
        for field_name in self.readonly_fields:
            self.fields[field_name].widget.attrs["readonly"] = "readonly"

        # for _, field in self.readonly_fields:
        #     field.widget.attrs["readonly"] = "readonly"


class BootstrapFormMixin:
    def _init_bootstrap_form(self):
        for _, field in self.fields:
            field.widget.attrs["class"] = "form-control"


class UpdatePersonForm(ReadonlyFieldsFormMixin, PersonForm):
    readonly_fields = ("last_name", "age")

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)

        self._mark_readonly_fields()


PersonForm2 = modelform_factory(Person, fields="__all__")

PersonFormSet = modelformset_factory(Person, exclude=("created_by",), extra=2)
