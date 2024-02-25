from django.urls import reverse_lazy
from django.views import generic as views

from djangoProject.car.models import Car
from djangoProject.common.helpers import get_profile
from djangoProject.profile.models import Profile
from djangoProject.web.form import ProfileWebForm


class IndexView(views.TemplateView):
    template_name = "index.html"

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        context["cars"] = Car.objects.all()
        return context

    def dispatch(self, request, *args, **kwargs):
        profile = get_profile()

        if not profile:
            return CreateProfileView.as_view()(request, *args, **kwargs)
        return super().dispatch(request, *args, **kwargs)


# Create your views here.
class CreateProfileView(views.CreateView):
    model = Profile
    form_class = ProfileWebForm  # or fields
    template_name = "profile/profile-create.html"
    success_url = reverse_lazy("index")

    def form_valid(self, form):
        profile = form.save()
        return super().form_valid(form)

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        context["no_nav"] = True
        return context
