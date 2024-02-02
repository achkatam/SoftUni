from django.shortcuts import render
from forms_advanced.web.forms import PersonForm, UpdatePersonForm, PersonFormSet


# Create your views here.
def index(request):
    person_form = PersonForm()
    update_person_form = UpdatePersonForm()

    context = {
        "person_form": person_form,
        "update_person_form": update_person_form,
    }

    return render(request, "web/index.html", context)


def show_formset(request):
    form_set = PersonFormSet()
    context = {
        "form_set": form_set,
    }

    return render(request, "web/formsets.html", context)


def create_person(request):
    form = PersonForm(request.POST, requtest.FILES, user=request.user)

    if form.is_valid():
        form.save()
