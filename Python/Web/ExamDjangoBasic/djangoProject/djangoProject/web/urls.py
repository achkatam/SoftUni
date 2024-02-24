from django.urls import path

from djangoProject.web.views import IndexView, CreateProfileView

urlpatterns = [
    path("", IndexView.as_view(), name="index"),
    path("create_profile/", CreateProfileView.as_view(), name="create_profile")
]

"""
http://localhost:8000/ - Index page 
"""
