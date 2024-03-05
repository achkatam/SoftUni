from django.urls import path

from exam_prep_my_music_app.profiles.views import DetailsProfileView, DeleteProfileView

urlpatterns = (
    path("details/", DetailsProfileView.as_view(), name="details_profile"),
    path("delete/", DeleteProfileView.as_view(), name="delete_profile"),
)
