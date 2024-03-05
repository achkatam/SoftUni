from django.urls import path

from djangoProject.profile.views import DetailsProfileView, EditProfileView, DeleteProfileView

urlpatterns = [
    path("details/", DetailsProfileView.as_view(), name="details_profile"),
    path("edit/", EditProfileView.as_view(), name="edit_profile"),
    path("delete/", DeleteProfileView.as_view(), name="delete_profile"),
]
