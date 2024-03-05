from django.urls import reverse_lazy
from django.views import generic as views

from djangoProject.common.helpers import get_profile
from djangoProject.profile.form import ProfileForm
from djangoProject.profile.models import Profile


# Create your views here.
class DetailsProfileView(views.DetailView):
    queryset = Profile.objects.all()
    template_name = "profile/profile-details.html"

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        user = self.object
        context["cars"] = user.car_set.all()
        context["total_price"] = sum(car.price for car in context["cars"])

        return context

    def get_object(self, queryset=None):
        return get_profile()


class EditProfileView(views.UpdateView):
    queryset = Profile.objects.all()
    template_name = "profile/profile-edit.html"
    form_class = ProfileForm
    success_url = reverse_lazy("details_profile")

    def get_object(self, queryset=None):
        return get_profile()


class DeleteProfileView(views.DeleteView):
    template_name = "profile/profile-delete.html"
    success_url = reverse_lazy("index")

    def get_object(self, queryset=None):
        return get_profile()
