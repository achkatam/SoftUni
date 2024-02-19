from django.shortcuts import render, redirect

from exam_prep_my_music_app.albums.models import Album
from exam_prep_my_music_app.profiles.models import Profile
from exam_prep_my_music_app.web.forms import CreateProfileForm


def get_profile():
    return Profile.objects.first()


def create_profile(request):
    form = CreateProfileForm(request.POST or None)

    if request.method == 'POST':
        if form.is_valid():
            profile = form.save()
            return redirect('index')

    context = {
        "form": form,
    }

    return render(request, "web/home-no-profile.html", context)


def index(request):
    profile = get_profile()

    if profile is None:
        return create_profile(request)

    context = {
        "albums": Album.objects.all(),
    }

    return render(request, "web/home-with-profile.html", context)
