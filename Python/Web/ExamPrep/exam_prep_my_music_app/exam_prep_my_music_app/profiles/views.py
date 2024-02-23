from django.urls import reverse_lazy
from django.views import generic as views

from exam_prep_my_music_app.common.profile_helpers import get_profile


# Create your views here.
class DetailsProfileView(views.DetailView):
    template_name = "profile/profile-details.html"

    def get_object(self, queryset=None):
        return get_profile()


class DeleteProfileView(views.DeleteView):
    template_name = "profile/profile-delete.html"
    success_url = reverse_lazy("index")

    def get_object(self, queryset=None):
        return get_profile()
