from django.urls import path
from forms_advanced.web.views import index, create_person, show_formset

urlpatterns = (
    path('', index, name="index"),
    path("person/create", create_person, name="create_person"),
    path("formsets/", show_formset, name="show_formset"),
)
