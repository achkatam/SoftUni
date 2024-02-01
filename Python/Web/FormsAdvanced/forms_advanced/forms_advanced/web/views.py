from django.shortcuts import render
from forms_advanced.web.forms import PersonForm

# Create your views here.
pf = PersonForm()

pf.is_valid()
