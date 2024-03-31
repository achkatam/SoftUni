from django.urls import path

from testing_demos.web.views import show_users, ListUsersView

urlpatterns = [
    path("", show_users, name="index fbv"),
    path("cbv/", ListUsersView.as_view(), name="index_cbv"),
]
