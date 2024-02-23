from django.views import generic as views

from exam_prep_my_music_app.albums.models import Album
from exam_prep_my_music_app.profiles.models import Profile


# Create your views here.
class ProfileFormMixin:
    def get_form(self, form_class=None):
        form = super().get_form(form_class)
        form.fields["username"].widget.attrs["placeholder"] = "Username"
        form.fields["email"].widget.attrs["placeholder"] = "Email"
        form.fields["age"].widget.attrs["placeholder"] = "Age"

        return form


class CreateProfileView(ProfileFormMixin, views.CreateView):
    model = Profile
    fields = ("username", "email", "age")
    template_name = 'web/home-no-profile.html'  # Adjust the template name
    success_url = '/'

    def form_valid(self, form):
        profile = form.save()
        return super().form_valid(form)

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        context["no_nav"] = True
        return context


class IndexView(views.CreateView):
    model = Profile
    fields = ("username", "email", "age")
    template_name = 'web/home-with-profile.html'  # Adjust the template name
    success_url = '/'

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        context["albums"] = Album.objects.all()

        return context

    def dispatch(self, request, *args, **kwargs):
        profile = Profile.objects.first()
        if not profile:
            return CreateProfileView.as_view()(request, *args, **kwargs)
        return super().dispatch(request, *args, **kwargs)
