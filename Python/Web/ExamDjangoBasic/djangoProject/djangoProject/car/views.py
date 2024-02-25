from django.forms import modelform_factory
from django.urls import reverse_lazy
from django.views import generic as views

from djangoProject.car.models import Car
from djangoProject.common.helpers import get_profile


class ReadonlyViewMixin:
    def get_form(self, form_class=None):
        form = super().get_form(form_class)

        for field in form.fields.values():
            field.widget.attrs["readonly"] = "readonly"

        return form


class CarPlaceholderMixin:
    def get_form(self, form_class=None):
        form = super().get_form(form_class)

        form.fields["image_url"].widget.attrs["placeholder"] = "https://..."

        return form


# Create your views here.
class CreateCarView(CarPlaceholderMixin, views.CreateView):
    model = Car
    fields = ("type", "model", "year", "image_url", "price")
    template_name = "car/car-create.html"
    success_url = reverse_lazy("catalogue")

    def form_valid(self, form):
        form.instance.owner_id = get_profile().pk

        return super().form_valid(form)


class DetailsCarView(views.DetailView):
    queryset = Car.objects.all()
    template_name = "car/car-details.html"


class EditCarView(views.UpdateView):
    queryset = Car.objects.all()
    template_name = "car/car-edit.html"

    fields = ("type", "model", "year", "image_url", "price")
    success_url = reverse_lazy("catalogue")


class DeleteCarView(ReadonlyViewMixin, views.DeleteView):
    queryset = Car.objects.all()
    template_name = "car/car-delete.html"
    success_url = reverse_lazy("catalogue")
    form_class = modelform_factory(Car,
                                   fields=("type", "model", "year", "image_url", "price"))

    def get_form_kwargs(self):
        kwargs = super().get_form_kwargs()

        kwargs["instance"] = self.object
        return kwargs


class CatalogueView(views.ListView):
    queryset = Car.objects.all()
    template_name = "car/catalogue.html"
    context_object_name = "cars"

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)

        context["cars"] = Car.objects.all()

        return context
