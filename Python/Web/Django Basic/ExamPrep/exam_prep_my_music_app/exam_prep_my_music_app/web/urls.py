from django.urls import path

from exam_prep_my_music_app.web.views import CreateProfileView, IndexView

urlpatterns = [
    path("", IndexView.as_view(), name="index"),
    path("create_profile/", CreateProfileView.as_view(), name="create_profile"),
]
